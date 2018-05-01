﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace BeFit
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::BeFit.BeFit_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::BeFit.BeFit_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::BeFit.BeFit_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace BeFit.BeFit_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[21];
            _typeNameTable[0] = "BeFit.AdminPage";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "BeFit.KlijentHomePage";
            _typeNameTable[4] = "BeFit.PodaciControl";
            _typeNameTable[5] = "String";
            _typeNameTable[6] = "BeFit.KlijentOsnovniPodaciPage";
            _typeNameTable[7] = "BeFit.MojiProgramiPage";
            _typeNameTable[8] = "BeFit.KreiranjeProgramaPage";
            _typeNameTable[9] = "BeFit.MainPage";
            _typeNameTable[10] = "BeFit.OdabirZaDodavanjeProgramaPage";
            _typeNameTable[11] = "BeFit.OpcijeProfilaPage";
            _typeNameTable[12] = "BeFit.PregledProfilaTreneraPage";
            _typeNameTable[13] = "BeFit.PregledProgramaPage";
            _typeNameTable[14] = "BeFit.PregledVjezbePage";
            _typeNameTable[15] = "BeFit.PretragaObjekataPage";
            _typeNameTable[16] = "BeFit.PretragaVjezbiPage";
            _typeNameTable[17] = "BeFit.PreuzimanjeProgramaPage";
            _typeNameTable[18] = "BeFit.ProgramControl";
            _typeNameTable[19] = "BeFit.RegistracijaPage";
            _typeNameTable[20] = "BeFit.VjezbaControl";

            _typeTable = new global::System.Type[21];
            _typeTable[0] = typeof(global::BeFit.AdminPage);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::BeFit.KlijentHomePage);
            _typeTable[4] = typeof(global::BeFit.PodaciControl);
            _typeTable[5] = typeof(global::System.String);
            _typeTable[6] = typeof(global::BeFit.KlijentOsnovniPodaciPage);
            _typeTable[7] = typeof(global::BeFit.MojiProgramiPage);
            _typeTable[8] = typeof(global::BeFit.KreiranjeProgramaPage);
            _typeTable[9] = typeof(global::BeFit.MainPage);
            _typeTable[10] = typeof(global::BeFit.OdabirZaDodavanjeProgramaPage);
            _typeTable[11] = typeof(global::BeFit.OpcijeProfilaPage);
            _typeTable[12] = typeof(global::BeFit.PregledProfilaTreneraPage);
            _typeTable[13] = typeof(global::BeFit.PregledProgramaPage);
            _typeTable[14] = typeof(global::BeFit.PregledVjezbePage);
            _typeTable[15] = typeof(global::BeFit.PretragaObjekataPage);
            _typeTable[16] = typeof(global::BeFit.PretragaVjezbiPage);
            _typeTable[17] = typeof(global::BeFit.PreuzimanjeProgramaPage);
            _typeTable[18] = typeof(global::BeFit.ProgramControl);
            _typeTable[19] = typeof(global::BeFit.RegistracijaPage);
            _typeTable[20] = typeof(global::BeFit.VjezbaControl);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_AdminPage() { return new global::BeFit.AdminPage(); }
        private object Activate_3_KlijentHomePage() { return new global::BeFit.KlijentHomePage(); }
        private object Activate_4_PodaciControl() { return new global::BeFit.PodaciControl(); }
        private object Activate_6_KlijentOsnovniPodaciPage() { return new global::BeFit.KlijentOsnovniPodaciPage(); }
        private object Activate_7_MojiProgramiPage() { return new global::BeFit.MojiProgramiPage(); }
        private object Activate_8_KreiranjeProgramaPage() { return new global::BeFit.KreiranjeProgramaPage(); }
        private object Activate_9_MainPage() { return new global::BeFit.MainPage(); }
        private object Activate_10_OdabirZaDodavanjeProgramaPage() { return new global::BeFit.OdabirZaDodavanjeProgramaPage(); }
        private object Activate_11_OpcijeProfilaPage() { return new global::BeFit.OpcijeProfilaPage(); }
        private object Activate_12_PregledProfilaTreneraPage() { return new global::BeFit.PregledProfilaTreneraPage(); }
        private object Activate_13_PregledProgramaPage() { return new global::BeFit.PregledProgramaPage(); }
        private object Activate_14_PregledVjezbePage() { return new global::BeFit.PregledVjezbePage(); }
        private object Activate_15_PretragaObjekataPage() { return new global::BeFit.PretragaObjekataPage(); }
        private object Activate_16_PretragaVjezbiPage() { return new global::BeFit.PretragaVjezbiPage(); }
        private object Activate_17_PreuzimanjeProgramaPage() { return new global::BeFit.PreuzimanjeProgramaPage(); }
        private object Activate_18_ProgramControl() { return new global::BeFit.ProgramControl(); }
        private object Activate_19_RegistracijaPage() { return new global::BeFit.RegistracijaPage(); }
        private object Activate_20_VjezbaControl() { return new global::BeFit.VjezbaControl(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::BeFit.BeFit_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::BeFit.BeFit_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  BeFit.AdminPage
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_AdminPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::BeFit.BeFit_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::BeFit.BeFit_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  BeFit.KlijentHomePage
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_3_KlijentHomePage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 4:   //  BeFit.PodaciControl
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_4_PodaciControl;
                userType.AddMemberName("Naziv");
                userType.AddMemberName("Podatak");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  String
                xamlType = new global::BeFit.BeFit_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  BeFit.KlijentOsnovniPodaciPage
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_6_KlijentOsnovniPodaciPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 7:   //  BeFit.MojiProgramiPage
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_MojiProgramiPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  BeFit.KreiranjeProgramaPage
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_KreiranjeProgramaPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  BeFit.MainPage
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_9_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  BeFit.OdabirZaDodavanjeProgramaPage
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_OdabirZaDodavanjeProgramaPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  BeFit.OpcijeProfilaPage
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_OpcijeProfilaPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  BeFit.PregledProfilaTreneraPage
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_PregledProfilaTreneraPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  BeFit.PregledProgramaPage
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_PregledProgramaPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 14:   //  BeFit.PregledVjezbePage
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_14_PregledVjezbePage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 15:   //  BeFit.PretragaObjekataPage
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_15_PretragaObjekataPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 16:   //  BeFit.PretragaVjezbiPage
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_16_PretragaVjezbiPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 17:   //  BeFit.PreuzimanjeProgramaPage
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_17_PreuzimanjeProgramaPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 18:   //  BeFit.ProgramControl
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_18_ProgramControl;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 19:   //  BeFit.RegistracijaPage
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_19_RegistracijaPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 20:   //  BeFit.VjezbaControl
                userType = new global::BeFit.BeFit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_20_VjezbaControl;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_PodaciControl_Naziv(object instance)
        {
            var that = (global::BeFit.PodaciControl)instance;
            return that.Naziv;
        }
        private void set_0_PodaciControl_Naziv(object instance, object Value)
        {
            var that = (global::BeFit.PodaciControl)instance;
            that.Naziv = (global::System.String)Value;
        }
        private object get_1_PodaciControl_Podatak(object instance)
        {
            var that = (global::BeFit.PodaciControl)instance;
            return that.Podatak;
        }
        private void set_1_PodaciControl_Podatak(object instance, object Value)
        {
            var that = (global::BeFit.PodaciControl)instance;
            that.Podatak = (global::System.String)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::BeFit.BeFit_XamlTypeInfo.XamlMember xamlMember = null;
            global::BeFit.BeFit_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "BeFit.PodaciControl.Naziv":
                userType = (global::BeFit.BeFit_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BeFit.PodaciControl");
                xamlMember = new global::BeFit.BeFit_XamlTypeInfo.XamlMember(this, "Naziv", "String");
                xamlMember.Getter = get_0_PodaciControl_Naziv;
                xamlMember.Setter = set_0_PodaciControl_Naziv;
                break;
            case "BeFit.PodaciControl.Podatak":
                userType = (global::BeFit.BeFit_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BeFit.PodaciControl");
                xamlMember = new global::BeFit.BeFit_XamlTypeInfo.XamlMember(this, "Podatak", "String");
                xamlMember.Getter = get_1_PodaciControl_Podatak;
                xamlMember.Setter = set_1_PodaciControl_Podatak;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::BeFit.BeFit_XamlTypeInfo.XamlSystemBaseType
    {
        global::BeFit.BeFit_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::BeFit.BeFit_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::BeFit.BeFit_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::BeFit.BeFit_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}

