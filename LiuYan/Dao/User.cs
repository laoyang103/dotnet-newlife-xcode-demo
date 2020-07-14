using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace User
{
    /// <summary>User</summary>
    [Serializable]
    [DataObject]
    [Description("User")]
    [BindTable("User", Description = "User", ConnName = "MysqlConn", DbType = DatabaseType.None)]
    public partial class User : IUser
    {
        #region 属性
        private Int32 _id;
        /// <summary></summary>
        [DisplayName("id")]
        [DataObjectField(true, true, false, 11)]
        [BindColumn("id", "", "int(11)")]
        public Int32 id { get => _id; set { if (OnPropertyChanging("id", value)) { _id = value; OnPropertyChanged("id"); } } }

        private String _Username;
        /// <summary></summary>
        [DisplayName("Username")]
        [DataObjectField(false, false, false, 32)]
        [BindColumn("username", "", "varchar(32)")]
        public String Username { get => _Username; set { if (OnPropertyChanging("Username", value)) { _Username = value; OnPropertyChanged("Username"); } } }

        private String _Password;
        /// <summary></summary>
        [DisplayName("Password")]
        [DataObjectField(false, false, false, 64)]
        [BindColumn("password", "", "varchar(64)")]
        public String Password { get => _Password; set { if (OnPropertyChanging("Password", value)) { _Password = value; OnPropertyChanged("Password"); } } }

        private String _Realname;
        /// <summary></summary>
        [DisplayName("Realname")]
        [DataObjectField(false, false, false, 32)]
        [BindColumn("realname", "", "varchar(32)")]
        public String Realname { get => _Realname; set { if (OnPropertyChanging("Realname", value)) { _Realname = value; OnPropertyChanged("Realname"); } } }

        private String _Email;
        /// <summary></summary>
        [DisplayName("Email")]
        [DataObjectField(false, false, true, 64)]
        [BindColumn("email", "", "varchar(64)")]
        public String Email { get => _Email; set { if (OnPropertyChanging("Email", value)) { _Email = value; OnPropertyChanged("Email"); } } }

        private String _Telephone;
        /// <summary></summary>
        [DisplayName("Telephone")]
        [DataObjectField(false, false, false, 32)]
        [BindColumn("telephone", "", "varchar(32)")]
        public String Telephone { get => _Telephone; set { if (OnPropertyChanging("Telephone", value)) { _Telephone = value; OnPropertyChanged("Telephone"); } } }
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
                    case "Username": return _Username;
                    case "Password": return _Password;
                    case "Realname": return _Realname;
                    case "Email": return _Email;
                    case "Telephone": return _Telephone;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "id": _id = value.ToInt(); break;
                    case "Username": _Username = Convert.ToString(value); break;
                    case "Password": _Password = Convert.ToString(value); break;
                    case "Realname": _Realname = Convert.ToString(value); break;
                    case "Email": _Email = Convert.ToString(value); break;
                    case "Telephone": _Telephone = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得User字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field id = FindByName("id");

            /// <summary></summary>
            public static readonly Field Username = FindByName("Username");

            /// <summary></summary>
            public static readonly Field Password = FindByName("Password");

            /// <summary></summary>
            public static readonly Field Realname = FindByName("Realname");

            /// <summary></summary>
            public static readonly Field Email = FindByName("Email");

            /// <summary></summary>
            public static readonly Field Telephone = FindByName("Telephone");

            static Field FindByName(String name) => Meta.Table.FindByName(name);
        }

        /// <summary>取得User字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String id = "id";

            /// <summary></summary>
            public const String Username = "Username";

            /// <summary></summary>
            public const String Password = "Password";

            /// <summary></summary>
            public const String Realname = "Realname";

            /// <summary></summary>
            public const String Email = "Email";

            /// <summary></summary>
            public const String Telephone = "Telephone";
        }
        #endregion
    }

    /// <summary>User接口</summary>
    public partial interface IUser
    {
        #region 属性
        /// <summary></summary>
        Int32 id { get; set; }

        /// <summary></summary>
        String Username { get; set; }

        /// <summary></summary>
        String Password { get; set; }

        /// <summary></summary>
        String Realname { get; set; }

        /// <summary></summary>
        String Email { get; set; }

        /// <summary></summary>
        String Telephone { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}