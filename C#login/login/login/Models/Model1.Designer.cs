//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace login.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class bdloginEntities1 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new bdloginEntities1 object using the connection string found in the 'bdloginEntities1' section of the application configuration file.
        /// </summary>
        public bdloginEntities1() : base("name=bdloginEntities1", "bdloginEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new bdloginEntities1 object.
        /// </summary>
        public bdloginEntities1(string connectionString) : base(connectionString, "bdloginEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new bdloginEntities1 object.
        /// </summary>
        public bdloginEntities1(EntityConnection connection) : base(connection, "bdloginEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<usuariose> usuariose
        {
            get
            {
                if ((_usuariose == null))
                {
                    _usuariose = base.CreateObjectSet<usuariose>("usuariose");
                }
                return _usuariose;
            }
        }
        private ObjectSet<usuariose> _usuariose;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the usuariose EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTousuariose(usuariose usuariose)
        {
            base.AddObject("usuariose", usuariose);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="bdloginModel", Name="usuariose")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class usuariose : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new usuariose object.
        /// </summary>
        /// <param name="iduser">Initial value of the iduser property.</param>
        /// <param name="nombre">Initial value of the nombre property.</param>
        /// <param name="telefono">Initial value of the telefono property.</param>
        /// <param name="usuario">Initial value of the usuario property.</param>
        /// <param name="pass">Initial value of the pass property.</param>
        /// <param name="rol">Initial value of the rol property.</param>
        /// <param name="empresa">Initial value of the empresa property.</param>
        public static usuariose Createusuariose(global::System.Int32 iduser, global::System.String nombre, global::System.String telefono, global::System.String usuario, global::System.String pass, global::System.String rol, global::System.String empresa)
        {
            usuariose usuariose = new usuariose();
            usuariose.iduser = iduser;
            usuariose.nombre = nombre;
            usuariose.telefono = telefono;
            usuariose.usuario = usuario;
            usuariose.pass = pass;
            usuariose.rol = rol;
            usuariose.empresa = empresa;
            return usuariose;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 iduser
        {
            get
            {
                return _iduser;
            }
            set
            {
                if (_iduser != value)
                {
                    OniduserChanging(value);
                    ReportPropertyChanging("iduser");
                    _iduser = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("iduser");
                    OniduserChanged();
                }
            }
        }
        private global::System.Int32 _iduser;
        partial void OniduserChanging(global::System.Int32 value);
        partial void OniduserChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                OnnombreChanging(value);
                ReportPropertyChanging("nombre");
                _nombre = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("nombre");
                OnnombreChanged();
            }
        }
        private global::System.String _nombre;
        partial void OnnombreChanging(global::System.String value);
        partial void OnnombreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                OntelefonoChanging(value);
                ReportPropertyChanging("telefono");
                _telefono = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("telefono");
                OntelefonoChanged();
            }
        }
        private global::System.String _telefono;
        partial void OntelefonoChanging(global::System.String value);
        partial void OntelefonoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                OnusuarioChanging(value);
                ReportPropertyChanging("usuario");
                _usuario = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("usuario");
                OnusuarioChanged();
            }
        }
        private global::System.String _usuario;
        partial void OnusuarioChanging(global::System.String value);
        partial void OnusuarioChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String pass
        {
            get
            {
                return _pass;
            }
            set
            {
                OnpassChanging(value);
                ReportPropertyChanging("pass");
                _pass = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("pass");
                OnpassChanged();
            }
        }
        private global::System.String _pass;
        partial void OnpassChanging(global::System.String value);
        partial void OnpassChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String rol
        {
            get
            {
                return _rol;
            }
            set
            {
                OnrolChanging(value);
                ReportPropertyChanging("rol");
                _rol = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("rol");
                OnrolChanged();
            }
        }
        private global::System.String _rol;
        partial void OnrolChanging(global::System.String value);
        partial void OnrolChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String empresa
        {
            get
            {
                return _empresa;
            }
            set
            {
                OnempresaChanging(value);
                ReportPropertyChanging("empresa");
                _empresa = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("empresa");
                OnempresaChanged();
            }
        }
        private global::System.String _empresa;
        partial void OnempresaChanging(global::System.String value);
        partial void OnempresaChanged();

        #endregion

    
    }

    #endregion

    
}
