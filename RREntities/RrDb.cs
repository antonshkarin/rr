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
            return ConfigurationManager.ConnectionStrings["rr_dbEntities"].ConnectionString;
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
        public int ToothCrownDestructionIndex { get; set; } // TODO: определить тип
        public BiteType Bite { get; set; }
        public PeriodontalDiseaseType PeriodontalDisease { get; set; }
        public BadHabitsType BadHabits { get; set; }

        public String chooseMethod()
        {
            return "Не знаю";
        }
    }


    public partial class rr_history
    {
        public static rr_history Create<T>(String firstName, String secondName, String lastName, DateTime date, Int64 type, T info)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer(); 
            String serInfo = serializer.Serialize(info);

            rr_history row = new rr_history { first_name = firstName, second_name = secondName, last_name = lastName, date = date, type = type, info = serInfo };

            return row;
        }
    }


    public class RrDb
    {
        public static RrEntities dbContext = RrEntities.Create();

        public void Add(rr_history entry)
        {
            dbContext.rr_history.Attach(entry);
            dbContext.SaveChanges();
        }

        public T Find<T>(String lastName)
        {
            var entries = dbContext.rr_history.Where(x => (x.last_name == lastName));
            return (T)Convert.ChangeType(entries, typeof(T));
        }
    }
}
