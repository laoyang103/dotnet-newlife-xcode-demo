using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace LiuYan
{
    /// <summary>LiuYan</summary>
    [Serializable]
    [DataObject]
    [Description("LiuYan")]
    [BindTable("LiuYan", Description = "LiuYan", ConnName = "MysqlConn", DbType = DatabaseType.None)]
    public partial class LiuYan : ILiuYan
    {
        #region 属性
        private Int32 _id;
        /// <summary></summary>
        [DisplayName("id")]
        [DataObjectField(true, true, false, 11)]
        [BindColumn("id", "", "int(11)")]
        public Int32 id { get => _id; set { if (OnPropertyChanging("id", value)) { _id = value; OnPropertyChanged("id"); } } }

        private Int32 _Userid;
        /// <summary></summary>
        [DisplayName("Userid")]
        [DataObjectField(false, false, false, 11)]
        [BindColumn("userid", "", "int(11)")]
        public Int32 Userid { get => _Userid; set { if (OnPropertyChanging("Userid", value)) { _Userid = value; OnPropertyChanged("Userid"); } } }

        private String _Detail;
        /// <summary></summary>
        [DisplayName("Detail")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("detail", "", "text")]
        public String Detail { get => _Detail; set { if (OnPropertyChanging("Detail", value)) { _Detail = value; OnPropertyChanged("Detail"); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case "id": return _id;
                    case "Userid": return _Userid;
                    case "Detail": return _Detail;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "id": _id = value.ToInt(); break;
                    case "Userid": _Userid = value.ToInt(); break;
                    case "Detail": _Detail = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得LiuYan字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field id = FindByName("id");

            /// <summary></summary>
            public static readonly Field Userid = FindByName("Userid");

            /// <summary></summary>
            public static readonly Field Detail = FindByName("Detail");

            static Field FindByName(String name) => Meta.Table.FindByName(name);
        }

        /// <summary>取得LiuYan字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String id = "id";

            /// <summary></summary>
            public const String Userid = "Userid";

            /// <summary></summary>
            public const String Detail = "Detail";
        }
        #endregion
    }

    /// <summary>LiuYan接口</summary>
    public partial interface ILiuYan
    {
        #region 属性
        /// <summary></summary>
        Int32 id { get; set; }

        /// <summary></summary>
        Int32 Userid { get; set; }

        /// <summary></summary>
        String Detail { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}