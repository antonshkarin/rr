using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Configuration;
using System.Data.Objects.DataClasses;
using System.Web.Script.Serialization;

namespace RREntities
{
    public partial class RrEntities : ObjectContext
    {
        public static String GetConnectionString()
        {
            String connStr = String.Format(
                "metadata=res://*/RrHistory.csdl|res://*/RrHistory.ssdl|res://*/RrHistory.msl;provider=System.Data.SQLite;provider connection string='{0}'",
                ConfigurationManager.ConnectionStrings["rr_dbEntities0"].ConnectionString);
            return connStr;
        }

        public static RrEntities Create()
        {
            return new RrEntities(GetConnectionString());
        }
    }


    public enum VizualToothColorType
    {
        Equal,
        Periodontitis,
        Depulped
    }

    public enum InstrumentalToothColorType
    {
        Equal,
        NotEqualVizual,
        NotEqual
    }

    public enum FissureType
    {
        Type1,
        Type2,
        Type3
    }

    public enum ToothCrownDestructionIndexType
    {
        Class5_30percents,
        Class5and6_Class_3and4_60_percents,
        Class3and4and5_more_than_60_percents
    }

    public enum BiteType
    {
        Open,
        Deep,
        Other
    }
 
    public enum PeriodontalDiseaseType
    {
        Healthy,
        Low,
        Medium
    }

    public enum BadHabitsType
    {
        No,
        Other,
        AnyBiting
    }

    public enum OccupationalInsalubrityType
    {
        No,
        WithoutPhysicalStresses,
        Other
    }

    [Serializable]
    public class DiagnosticCard
    {
        public double HygieneIndex { get; set; }
        public VizualToothColorType VizualToothColor { get; set; }
        public InstrumentalToothColorType InstrumentalToothColor { get; set; }
        public FissureType PresenceOfFissures { get; set; }
        public int ResistanceEnamelLevel { get; set; }
        public ToothCrownDestructionIndexType ToothCrownDestructionIndex { get; set; }
        public BiteType Bite { get; set; }
        public PeriodontalDiseaseType PeriodontalDisease { get; set; }
        public BadHabitsType BadHabits { get; set; }
        public OccupationalInsalubrityType OccupationalInsalubrity { get; set; }

        public String chooseMethod()
        {
            int total = 0;
            
            if (HygieneIndex <= 1.2)
                total += 2;
            else if (HygieneIndex <= 3.0)
                total += 3;
            else if (HygieneIndex > 3.0)
                total += 4;

            if (VizualToothColor == VizualToothColorType.Equal)
                total += 2;
            else if (VizualToothColor == VizualToothColorType.Periodontitis)
                total += 3;
            else if (VizualToothColor == VizualToothColorType.Depulped)
                total += 4;

            if (InstrumentalToothColor == InstrumentalToothColorType.Equal)
                total += 2;
            else if (InstrumentalToothColor == InstrumentalToothColorType.NotEqualVizual)
                total += 3;
            else if (InstrumentalToothColor == InstrumentalToothColorType.NotEqual)
                total += 4;

            if (PresenceOfFissures == FissureType.Type1)
                total += 2;
            else if (PresenceOfFissures == FissureType.Type2)
                total += 3;
            else if (PresenceOfFissures == FissureType.Type3)
                total += 4;

            if (ResistanceEnamelLevel >= 71)
                total += 2;
            else if (ResistanceEnamelLevel >= 30)
                total += 3;
            else if (ResistanceEnamelLevel >= 10)
                total += 4;

            if (ToothCrownDestructionIndex == ToothCrownDestructionIndexType.Class5_30percents)
                total += 2;
            else if (ToothCrownDestructionIndex == ToothCrownDestructionIndexType.Class5and6_Class_3and4_60_percents)
                total += 3;
            else if (ToothCrownDestructionIndex == ToothCrownDestructionIndexType.Class3and4and5_more_than_60_percents)
                total += 4;

            if (Bite == BiteType.Open)
                total += 2;
            else if (Bite == BiteType.Deep)
                total += 3;
            else if (Bite == BiteType.Other)
                total += 4;

            if (PeriodontalDisease == PeriodontalDiseaseType.Healthy)
                total += 2;
            else if (PeriodontalDisease == PeriodontalDiseaseType.Low)
                total += 3;
            else if (PeriodontalDisease == PeriodontalDiseaseType.Medium)
                total += 4;

            if (BadHabits == BadHabitsType.No)
                total += 2;
            else if (BadHabits == BadHabitsType.Other)
                total += 3;
            else if (BadHabits == BadHabitsType.AnyBiting)
                total += 4;

            if (OccupationalInsalubrity == OccupationalInsalubrityType.No)
                total += 2;
            else if (OccupationalInsalubrity == OccupationalInsalubrityType.WithoutPhysicalStresses)
                total += 3;
            else if (OccupationalInsalubrity == OccupationalInsalubrityType.Other)
                total += 4;

            if (total >= 24 && total <= 35)
                return "Прямой метод реставрации (терапевтический метод)";
            else if (total >= 36 && total <= 48)
                return "Непрямой метод реставрации (ортопедический метод)";

            throw new Exception("По кол-ву баллов и один из методов не подходит");
        }
    }

    [Serializable]
    public class EstimationCard
    {
        int СоответствиеФормыЗубаОвалуЛица;

    }

    public partial class rr_history
    {
        public enum RowType
        {
            Diagnostics,
            Estimation
        }

        public static rr_history Create<T>(String firstName, String secondName, String lastName, DateTime date, RowType type, T info)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer(); 
            String serInfo = serializer.Serialize(info);

            rr_history row = new rr_history { first_name = firstName, second_name = secondName, last_name = lastName, date = date, type = (Int64)type, info = serInfo };

            return row;
        }
    }


    public class RrDb
    {
        public static RrEntities dbContext = RrEntities.Create();

        public void Add(rr_history entry)
        {
            dbContext.rr_history.AddObject(entry);
            dbContext.SaveChanges();
        }

        public T Find<T>(String lastName)
        {
            var entries = dbContext.rr_history.Where(x => (x.last_name == lastName));
            return (T)Convert.ChangeType(entries, typeof(T));
        }
    }
}
