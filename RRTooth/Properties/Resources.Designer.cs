﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RRTooth.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RRTooth.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Критерии оценки:
        ///Если отсутствую вредные привычки– 2 балла
        ///Если имеются вредные привычки жевательные конфеты, жевательная резинка, семечки – 3 балла
        ///Если у пациента имеется вредная привычка грызть орехи, ручку, ногти – 4 балла.
        /// </summary>
        internal static string DescBadHabits {
            get {
                return ResourceManager.GetString("DescBadHabits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Критерии оценки:
        ///Если у пациента ортогнатический, открытый прикус, прогения – 2 балла
        ///Если у пациента глубокое резцовое перекрытие – 3 балла
        ///Если у пациента прикус любого другого вида – 4 балла.
        /// </summary>
        internal static string DescBite {
            get {
                return ResourceManager.GetString("DescBite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Методика:
        ///Наличие трещин оценивается после высушивания и витального окрашивания 2% раствором метиленового синего и внутриротового подсвечивания.
        ///Трещины I типа – очень тонкие, заметные после высушивания и витального окрашивания, также внутриротового освечивания – 2 балла
        ///Трещины II типа – определяются сразу после высушивания и внутриротового освещения – 3 балла
        ///Трещины III типа – глубокие, выявляются при обычном освещении поверхности зуба – 4 балла..
        /// </summary>
        internal static string DescFissure {
            get {
                return ResourceManager.GetString("DescFissure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Методика:
        ///Индекс гигиены полости рта оценивали по упрощенному OHI (Green, Vermillion, 1964). Позволяет определить отдельно наличие зубного налета и зубного камня. Для определения данного индекса обследуют 6 зубов: 1.6, 1.1, 2.6, 3.1 – вестибулярные поверхности и 3.6, 4.6 – язычные поверхности. Оценка зубного налета проводится визуально при окрашивании налета 2% раствором эритрозина.
        ///0-	Зубной налет отсутствует
        ///1-	зубной налет покрывает не более 1/3 поверхности зуба
        ///2-	зубной налет покрывает до 2/3 повер [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DescHygieneIndex {
            get {
                return ResourceManager.GetString("DescHygieneIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Методика:
        ///Состояние пародонта оценивали с помощью индекса папилляро-маргинально-альвеолярный индекс (РМА). Воспалительный процесс оценивали по степени окрашивания десны йодсодержащим раствором.
        ///0 – воспаление отсутствует
        ///1 – воспаление десневого сосочка
        ///2 – воспаление маргинальной десны
        ///3 – воспаление альвеолярной десны
        ///
        ///Критерии оценки:
        ///25-30% легкая степень тяжести – 2 балла
        ///30-60% средняя степень тяжести – 3 балла
        ///&gt;60% тяжелая степень тяжести– 4 балла.
        /// </summary>
        internal static string DescPeriodontalDisease {
            get {
                return ResourceManager.GetString("DescPeriodontalDisease", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Критерии оценки:
        ///Если нет профессиональных вредностей  – 2 балла
        ///Если пациенты заняты на любом производстве без физических нагрузок – 3 балла
        ///Если пациенты заняты на химическом производстве, кондитерском производстве, хлебобулочное производство, спортсмены (с сильными физическими нагрузками), швеи, сапожники, шорники - 4 балла.
        /// </summary>
        internal static string DescProfessionalHarmfulness {
            get {
                return ResourceManager.GetString("DescProfessionalHarmfulness", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Методика:
        ///Определение уровня резистетности эмали по методике Л.А. Аксамит (1973), методика заключается в витальном окрашивании протравленного участка эмали. Поверхность исследуемого зуба тщательно очищают от налета 3% раствором перекиси водорода, просушивают струей воздуха, далее на вестибулярную поверхность исследуемого зуба наносят полиэтиленовую липкую ленту в центре которой имеется округлое отверстие в диаметре 2,8 мм, затем в это «окно» наносят деминерализующий раствор на 30 секунд, рН – 0,37, кислотн [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DescResistanceEnamel {
            get {
                return ResourceManager.GetString("DescResistanceEnamel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Методика:
        ///Цвет зуба оценивается 2 методами: 
        ///1.	колориметрический (аппаратурный) 
        ///2.	визуальный 
        ///Метод аппаратурный:
        ///Если цвет реставрируемого зуба совпадает с цветом соответствующего интактного зуба расположенного на противоположной стороне  - 2 балла
        ///Если цвет при визуальной оценке и аппаратурной не совпадают между собой – 3 балла
        ///Если цвет реставрируемого зуба не совпадает с цветом соответствующего интактного зуба расположенного на противоположной стороне  - 4 балла
        ///Метод визуальный:
        ///Если цвет р [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DescToothColor {
            get {
                return ResourceManager.GetString("DescToothColor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Методика:
        ///Для описания индекса разрушения коронки зуба (ИРОПЗ) мы использовали индекс разрушения окклюзионной поверхности зубов (В.Ю. Миликевич, 1984) который был предложен для определения площади разрушения зуба. По данной методике всю окклюзионную площадь поверхности зуба принимают за единицу, при разрушении 55% показаны вкладки, а при индексе разрушения больше 80 % – показано изготовление штифтовых конструкций. Индекс ИРОПЗ это соотношение размеров площади «полость-пломба» к жевательной поверхности зуба [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DescToothCrownDestruction {
            get {
                return ResourceManager.GetString("DescToothCrownDestruction", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap rr_diagnostics {
            get {
                object obj = ResourceManager.GetObject("rr_diagnostics", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap rr_evaluation {
            get {
                object obj = ResourceManager.GetObject("rr_evaluation", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap rr_history {
            get {
                object obj = ResourceManager.GetObject("rr_history", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap rr_icon {
            get {
                object obj = ResourceManager.GetObject("rr_icon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap Tooth {
            get {
                object obj = ResourceManager.GetObject("Tooth", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap tooths1 {
            get {
                object obj = ResourceManager.GetObject("tooths1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap tooths2 {
            get {
                object obj = ResourceManager.GetObject("tooths2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
