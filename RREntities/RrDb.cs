﻿using System;
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
                ConfigurationManager.ConnectionStrings["rr_dbEntities1"].ConnectionString);
            return connStr;
        }

        public static RrEntities Create()
        {
            return new RrEntities(GetConnectionString());
        }
    }

    public enum HygieneIndexType
    {
        val0_12,
        val13_30,
        val31_60
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

    public enum ResistanceEnamelLevelType
    {
        val10_40,
        val41_60,
        val60_100
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
        public HygieneIndexType HygieneIndex { get; set; }
        public VizualToothColorType VizualToothColor { get; set; }
        public InstrumentalToothColorType InstrumentalToothColor { get; set; }
        public FissureType PresenceOfFissures { get; set; }
        public ResistanceEnamelLevelType ResistanceEnamelLevel { get; set; }
        public ToothCrownDestructionIndexType ToothCrownDestructionIndex { get; set; }
        public BiteType Bite { get; set; }
        public PeriodontalDiseaseType PeriodontalDisease { get; set; }
        public BadHabitsType BadHabits { get; set; }
        public OccupationalInsalubrityType OccupationalInsalubrity { get; set; }

        public String chooseMethod()
        {
            int total = 0;
            
            if (HygieneIndex == HygieneIndexType.val0_12)
                total += 2;
            else if (HygieneIndex == HygieneIndexType.val13_30)
                total += 3;
            else if (HygieneIndex == HygieneIndexType.val31_60)
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

            if (ResistanceEnamelLevel == ResistanceEnamelLevelType.val10_40)
                total += 2;
            else if (ResistanceEnamelLevel == ResistanceEnamelLevelType.val41_60)
                total += 3;
            else if (ResistanceEnamelLevel == ResistanceEnamelLevelType.val60_100)
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

            if (/*total >= 24 && */total <= 35)
                return "Прямой метод реставрации (терапевтический метод)";
            else if (total >= 36 /*&& total <= 48*/)
                return "Непрямой метод реставрации (ортопедический метод)";

            throw new Exception("По кол-ву баллов и один из методов не подходит");
        }
    }

    [Serializable]
    public class EstimationCard
    {
        public int СоответствиеФормыЗубаОвалуЛица;
        public int ПропорцииСоблюдены;
        public int РежущийКрайФестончатость;
        public int КраевоеПрилегание;
        public int КонтактныйПункт;
        public int СоответствиеРеставрацииСрединнойЛинии;
        public int СоответствиеЦвета;
        public int ПлавностьПереходаЦветов;
        public int ИзменениеЦветаНаГраницеРеставрацииСЗубом;
        public int РежущийКрай;
        public int КонтактныеПоверхности;
        public int ОтсутствиеПрозрачности;
        public int ГладкостьПоверхности;
        public int БлескПоверхностиСухой;
        public int БлескПоверхностиВлажный;
        public int ОкклюзионныеВзаимоотношения;
        public int ПослеоперационнаяЧувствительность;
        public int Дикция;
        public int СостояниеПародонтаПослеРеставрации;
        public int ОценкаРеставрацииПациентом;
    }

    public partial class rr_history
    {
        public enum RowType
        {
            Diagnostics,
            Estimation
        }

        public static rr_history Create<T>(String firstName, String secondName, String lastName, DateTime date, RowType type, T info,
            DateTime birthday, String cardNumber, byte[] photo)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer(); 
            String serInfo = serializer.Serialize(info);

            rr_history row = new rr_history { 
                first_name = firstName, 
                second_name = secondName, 
                last_name = lastName, 
                date = date, 
                type = (Int64)type, 
                info = serInfo,
                birthday = birthday,
                card_number = cardNumber,
                photo = photo };

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

        public void Edit(rr_history entry)
        {
            var entryToUpd = dbContext.rr_history.First(e => e.id == entry.id);
            entryToUpd = entry;
            dbContext.SaveChanges();
        }

        public void Delete(rr_history entry)
        {
            dbContext.rr_history.DeleteObject(entry);
            dbContext.SaveChanges();
        }

        public List<rr_history> Find(String lastName, String firstName = "", String secondName = "", int? type = null)
        {
            String whereClause = String.Empty;
            if (lastName != "")
                whereClause += "it.last_name = '" + lastName + "'";
            if (firstName != "")
                whereClause += (whereClause.Length > 0 ? " and " : "") + " it.first_name = '" + firstName + "'";
            if (secondName != "")
                whereClause += (whereClause.Length > 0 ? " and " : "") + " it.second_name = '" + secondName + "'";

            if (type.HasValue)
                whereClause += (whereClause.Length > 0 ? " and " : "") + " it.type = " + type.Value;

            var entries = dbContext.rr_history.Where(whereClause).OrderBy(x => x.last_name);
            return entries.ToList();
        }
    }
}
