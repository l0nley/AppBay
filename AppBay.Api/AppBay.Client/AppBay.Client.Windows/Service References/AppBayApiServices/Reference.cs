//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 10/25/2014 11:14:50 PM
namespace AppBay.Client.AppBayApiServices
{
    
    /// <summary>
    /// There are no comments for Entities in the schema.
    /// </summary>
    public partial class Entities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Entities(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "AppBay.Classes.Models", "AppBay.Client.AppBayApiServices");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("AppBay.Client.AppBayApiServices", global::System.StringComparison.Ordinal))
            {
                return string.Concat("AppBay.Classes.Models.", clientType.Name);
            }
            return clientType.FullName;
        }
        /// <summary>
        /// There are no comments for Jobs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<JobDescription> Jobs
        {
            get
            {
                if ((this._Jobs == null))
                {
                    this._Jobs = base.CreateQuery<JobDescription>("Jobs");
                }
                return this._Jobs;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<JobDescription> _Jobs;
        /// <summary>
        /// There are no comments for Packages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Package> Packages
        {
            get
            {
                if ((this._Packages == null))
                {
                    this._Packages = base.CreateQuery<Package>("Packages");
                }
                return this._Packages;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Package> _Packages;
        /// <summary>
        /// There are no comments for JobResults in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<JobResult> JobResults
        {
            get
            {
                if ((this._JobResults == null))
                {
                    this._JobResults = base.CreateQuery<JobResult>("JobResults");
                }
                return this._JobResults;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<JobResult> _JobResults;
        /// <summary>
        /// There are no comments for Jobs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToJobs(JobDescription jobDescription)
        {
            base.AddObject("Jobs", jobDescription);
        }
        /// <summary>
        /// There are no comments for Packages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToPackages(Package package)
        {
            base.AddObject("Packages", package);
        }
        /// <summary>
        /// There are no comments for JobResults in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToJobResults(JobResult jobResult)
        {
            base.AddObject("JobResults", jobResult);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private const string ModelPart0 = "<edmx:Edmx Version=\"1.0\" xmlns:edmx=\"http://schemas.microsoft.com/ado/2007/06/edm" +
                "x\"><edmx:DataServices m:DataServiceVersion=\"1.0\" m:MaxDataServiceVersion=\"3.0\" x" +
                "mlns:m=\"http://schemas.microsoft.com/ado/2007/08/dataservices/metadata\"><Schema " +
                "Namespace=\"AppBay.Classes.Models\" xmlns=\"http://schemas.microsoft.com/ado/2006/0" +
                "4/edm\"><EntityType Name=\"BaseCollectionEntity\"><Key><PropertyRef Name=\"Id\" /></K" +
                "ey><Property Name=\"Id\" Type=\"Edm.String\" Nullable=\"false\" /><Property Name=\"Coll" +
                "ectionName\" Type=\"Edm.String\" /></EntityType><EntityType Name=\"JobDescription\" B" +
                "aseType=\"AppBay.Classes.Models.BaseCollectionEntity\"><Property Name=\"PackageId\" " +
                "Type=\"Edm.Int32\" Nullable=\"false\" /><Property Name=\"Description\" Type=\"Edm.Strin" +
                "g\" /><Property Name=\"SerializedInput\" Type=\"Edm.String\" /><Property Name=\"Added\"" +
                " Type=\"Edm.DateTime\" Nullable=\"false\" /><Property Name=\"Started\" Type=\"Edm.DateT" +
                "ime\" /><Property Name=\"IsRunning\" Type=\"Edm.Boolean\" Nullable=\"false\" /></Entity" +
                "Type><EntityType Name=\"Package\" BaseType=\"AppBay.Classes.Models.BaseCollectionEn" +
                "tity\"><Property Name=\"PackageId\" Type=\"Edm.Int32\" Nullable=\"false\" /><Property N" +
                "ame=\"Description\" Type=\"Edm.String\" /><Property Name=\"TargetClassName\" Type=\"Edm" +
                ".String\" /><Property Name=\"Payload\" Type=\"Edm.Binary\" /></EntityType><EntityType" +
                " Name=\"JobResult\" BaseType=\"AppBay.Classes.Models.BaseCollectionEntity\"><Propert" +
                "y Name=\"Description\" Type=\"Edm.String\" /><Property Name=\"Started\" Type=\"Edm.Date" +
                "Time\" Nullable=\"false\" /><Property Name=\"Finished\" Type=\"Edm.DateTime\" Nullable=" +
                "\"false\" /><Property Name=\"IsSuccess\" Type=\"Edm.Boolean\" Nullable=\"false\" /><Prop" +
                "erty Name=\"ErrorMessage\" Type=\"Edm.String\" /><Property Name=\"SerializedResult\" T" +
                "ype=\"Edm.String\" /></EntityType><EntityContainer Name=\"Entities\" m:IsDefaultEnti" +
                "tyContainer=\"true\"><EntitySet Name=\"Jobs\" EntityType=\"AppBay.Classes.Models.JobD" +
                "escription\" /><EntitySet Name=\"Packages\" EntityType=\"AppBay.Classes.Models.Packa" +
                "ge\" /><EntitySet Name=\"JobResults\" EntityType=\"AppBay.Classes.Models.JobResult\" " +
                "/></EntityContainer></Schema></edmx:DataServices></edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static string GetConcatenatedEdmxString()
            {
                return string.Concat(ModelPart0);
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            public static global::Microsoft.Data.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel LoadModelFromString()
            {
                string edmxToParse = GetConcatenatedEdmxString();
                global::System.Xml.XmlReader reader = CreateXmlReader(edmxToParse);
                try
                {
                    return global::Microsoft.Data.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for AppBay.Classes.Models.BaseCollectionEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class BaseCollectionEntity : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BaseCollectionEntity object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static BaseCollectionEntity CreateBaseCollectionEntity(string ID)
        {
            BaseCollectionEntity baseCollectionEntity = new BaseCollectionEntity();
            baseCollectionEntity.Id = ID;
            return baseCollectionEntity;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Id;
        partial void OnIdChanging(string value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property CollectionName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CollectionName
        {
            get
            {
                return this._CollectionName;
            }
            set
            {
                this.OnCollectionNameChanging(value);
                this._CollectionName = value;
                this.OnCollectionNameChanged();
                this.OnPropertyChanged("CollectionName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CollectionName;
        partial void OnCollectionNameChanging(string value);
        partial void OnCollectionNameChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for AppBay.Classes.Models.JobDescription in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Jobs")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class JobDescription : BaseCollectionEntity
    {
        /// <summary>
        /// Create a new JobDescription object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="packageId">Initial value of PackageId.</param>
        /// <param name="added">Initial value of Added.</param>
        /// <param name="isRunning">Initial value of IsRunning.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static JobDescription CreateJobDescription(string ID, int packageId, global::System.DateTime added, bool isRunning)
        {
            JobDescription jobDescription = new JobDescription();
            jobDescription.Id = ID;
            jobDescription.PackageId = packageId;
            jobDescription.Added = added;
            jobDescription.IsRunning = isRunning;
            return jobDescription;
        }
        /// <summary>
        /// There are no comments for Property PackageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int PackageId
        {
            get
            {
                return this._PackageId;
            }
            set
            {
                this.OnPackageIdChanging(value);
                this._PackageId = value;
                this.OnPackageIdChanged();
                this.OnPropertyChanged("PackageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _PackageId;
        partial void OnPackageIdChanging(int value);
        partial void OnPackageIdChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property SerializedInput in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SerializedInput
        {
            get
            {
                return this._SerializedInput;
            }
            set
            {
                this.OnSerializedInputChanging(value);
                this._SerializedInput = value;
                this.OnSerializedInputChanged();
                this.OnPropertyChanged("SerializedInput");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SerializedInput;
        partial void OnSerializedInputChanging(string value);
        partial void OnSerializedInputChanged();
        /// <summary>
        /// There are no comments for Property Added in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime Added
        {
            get
            {
                return this._Added;
            }
            set
            {
                this.OnAddedChanging(value);
                this._Added = value;
                this.OnAddedChanged();
                this.OnPropertyChanged("Added");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _Added;
        partial void OnAddedChanging(global::System.DateTime value);
        partial void OnAddedChanged();
        /// <summary>
        /// There are no comments for Property Started in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> Started
        {
            get
            {
                return this._Started;
            }
            set
            {
                this.OnStartedChanging(value);
                this._Started = value;
                this.OnStartedChanged();
                this.OnPropertyChanged("Started");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _Started;
        partial void OnStartedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnStartedChanged();
        /// <summary>
        /// There are no comments for Property IsRunning in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public bool IsRunning
        {
            get
            {
                return this._IsRunning;
            }
            set
            {
                this.OnIsRunningChanging(value);
                this._IsRunning = value;
                this.OnIsRunningChanged();
                this.OnPropertyChanged("IsRunning");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private bool _IsRunning;
        partial void OnIsRunningChanging(bool value);
        partial void OnIsRunningChanged();
    }
    /// <summary>
    /// There are no comments for AppBay.Classes.Models.Package in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Packages")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Package : BaseCollectionEntity
    {
        /// <summary>
        /// Create a new Package object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="packageId">Initial value of PackageId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Package CreatePackage(string ID, int packageId)
        {
            Package package = new Package();
            package.Id = ID;
            package.PackageId = packageId;
            return package;
        }
        /// <summary>
        /// There are no comments for Property PackageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int PackageId
        {
            get
            {
                return this._PackageId;
            }
            set
            {
                this.OnPackageIdChanging(value);
                this._PackageId = value;
                this.OnPackageIdChanged();
                this.OnPropertyChanged("PackageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _PackageId;
        partial void OnPackageIdChanging(int value);
        partial void OnPackageIdChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property TargetClassName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string TargetClassName
        {
            get
            {
                return this._TargetClassName;
            }
            set
            {
                this.OnTargetClassNameChanging(value);
                this._TargetClassName = value;
                this.OnTargetClassNameChanged();
                this.OnPropertyChanged("TargetClassName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _TargetClassName;
        partial void OnTargetClassNameChanging(string value);
        partial void OnTargetClassNameChanged();
        /// <summary>
        /// There are no comments for Property Payload in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public byte[] Payload
        {
            get
            {
                if ((this._Payload != null))
                {
                    return ((byte[])(this._Payload.Clone()));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnPayloadChanging(value);
                this._Payload = value;
                this.OnPayloadChanged();
                this.OnPropertyChanged("Payload");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private byte[] _Payload;
        partial void OnPayloadChanging(byte[] value);
        partial void OnPayloadChanged();
    }
    /// <summary>
    /// There are no comments for AppBay.Classes.Models.JobResult in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("JobResults")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class JobResult : BaseCollectionEntity
    {
        /// <summary>
        /// Create a new JobResult object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="started">Initial value of Started.</param>
        /// <param name="finished">Initial value of Finished.</param>
        /// <param name="isSuccess">Initial value of IsSuccess.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static JobResult CreateJobResult(string ID, global::System.DateTime started, global::System.DateTime finished, bool isSuccess)
        {
            JobResult jobResult = new JobResult();
            jobResult.Id = ID;
            jobResult.Started = started;
            jobResult.Finished = finished;
            jobResult.IsSuccess = isSuccess;
            return jobResult;
        }
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Started in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime Started
        {
            get
            {
                return this._Started;
            }
            set
            {
                this.OnStartedChanging(value);
                this._Started = value;
                this.OnStartedChanged();
                this.OnPropertyChanged("Started");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _Started;
        partial void OnStartedChanging(global::System.DateTime value);
        partial void OnStartedChanged();
        /// <summary>
        /// There are no comments for Property Finished in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime Finished
        {
            get
            {
                return this._Finished;
            }
            set
            {
                this.OnFinishedChanging(value);
                this._Finished = value;
                this.OnFinishedChanged();
                this.OnPropertyChanged("Finished");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _Finished;
        partial void OnFinishedChanging(global::System.DateTime value);
        partial void OnFinishedChanged();
        /// <summary>
        /// There are no comments for Property IsSuccess in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public bool IsSuccess
        {
            get
            {
                return this._IsSuccess;
            }
            set
            {
                this.OnIsSuccessChanging(value);
                this._IsSuccess = value;
                this.OnIsSuccessChanged();
                this.OnPropertyChanged("IsSuccess");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private bool _IsSuccess;
        partial void OnIsSuccessChanging(bool value);
        partial void OnIsSuccessChanged();
        /// <summary>
        /// There are no comments for Property ErrorMessage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ErrorMessage
        {
            get
            {
                return this._ErrorMessage;
            }
            set
            {
                this.OnErrorMessageChanging(value);
                this._ErrorMessage = value;
                this.OnErrorMessageChanged();
                this.OnPropertyChanged("ErrorMessage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ErrorMessage;
        partial void OnErrorMessageChanging(string value);
        partial void OnErrorMessageChanged();
        /// <summary>
        /// There are no comments for Property SerializedResult in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SerializedResult
        {
            get
            {
                return this._SerializedResult;
            }
            set
            {
                this.OnSerializedResultChanging(value);
                this._SerializedResult = value;
                this.OnSerializedResultChanged();
                this.OnPropertyChanged("SerializedResult");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SerializedResult;
        partial void OnSerializedResultChanging(string value);
        partial void OnSerializedResultChanged();
    }
}