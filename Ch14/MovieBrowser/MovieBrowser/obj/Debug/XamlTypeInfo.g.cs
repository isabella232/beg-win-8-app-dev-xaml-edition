﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml;
using MovieBrowser.MovieBrowser_XamlTypeInfo;

namespace MovieBrowser
{
    public partial class App : IXamlMetadataProvider
    {
        private XamlTypeInfoProvider _provider;

        public IXamlType GetXamlType(Type type)
        {
            if(_provider == null)
            {
                _provider = new XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public IXamlType GetXamlType(String typeName)
        {
            if(_provider == null)
            {
                _provider = new XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(typeName);
        }

        public XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new XmlnsDefinition[0];
        }
    }
}

namespace MovieBrowser.MovieBrowser_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public IXamlType GetXamlTypeByType(Type type)
        {
            string standardName;
            IXamlType xamlType = null;
            if(_xamlTypeToStandardName.TryGetValue(type, out standardName))
            {
                xamlType = GetXamlTypeByName(standardName);
            }
            else
            {
                xamlType = GetXamlTypeByName(type.FullName);
            }
            return xamlType;
        }

        public IXamlType GetXamlTypeByName(string typeName)
        {
            if (String.IsNullOrEmpty(typeName))
            {
                return null;
            }
            IXamlType xamlType;
            if (_xamlTypes.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            xamlType = CreateXamlType(typeName);
            if (xamlType != null)
            {
                _xamlTypes.Add(typeName, xamlType);
            }
            return xamlType;
        }

        public IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (String.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            IXamlMember xamlMember;
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

        Dictionary<string, IXamlType> _xamlTypes = new Dictionary<string, IXamlType>();
        Dictionary<string, IXamlMember> _xamlMembers = new Dictionary<string, IXamlMember>();
        Dictionary<Type, string> _xamlTypeToStandardName = new Dictionary<Type, string>();

        private void AddToMapOfTypeToStandardName(Type t, String str)
        {
            if(!_xamlTypeToStandardName.ContainsKey(t))
            {
                _xamlTypeToStandardName.Add(t, str);
            }
        }

        private object Activate_0_MovieBrowserViewModel() { return new MovieBrowser.DataModel.MovieBrowserViewModel(); }

        private object Activate_2_ObservableCollection() { return new System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Genre>(); }

        private object Activate_3_Collection() { return new System.Collections.ObjectModel.Collection<MovieBrowser.DataModel.Genre>(); }

        private object Activate_4_Genre() { return new MovieBrowser.DataModel.Genre(); }

        private object Activate_5_ObservableCollection() { return new System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Title>(); }

        private object Activate_6_Collection() { return new System.Collections.ObjectModel.Collection<MovieBrowser.DataModel.Title>(); }

        private object Activate_7_Title() { return new MovieBrowser.DataModel.Title(); }

        private object Activate_8_BoxArt() { return new MovieBrowser.DataModel.BoxArt(); }

        private object Activate_10_LayoutAwarePage() { return new MovieBrowser.Common.LayoutAwarePage(); }

        private object Activate_11_GroupedItemsPage() { return new MovieBrowser.GroupedItemsPage(); }

        private object Activate_12_GroupDetailPage() { return new MovieBrowser.GroupDetailPage(); }

        private object Activate_13_ItemDetailPage() { return new MovieBrowser.ItemDetailPage(); }

        private void VectorAdd_2_ObservableCollection(object instance, object item)
        {
            var collection = (System.Collections.Generic.ICollection<MovieBrowser.DataModel.Genre>)instance;
            var newItem = (MovieBrowser.DataModel.Genre)item;
            collection.Add(newItem);
        }

        private void VectorAdd_3_Collection(object instance, object item)
        {
            var collection = (System.Collections.Generic.ICollection<MovieBrowser.DataModel.Genre>)instance;
            var newItem = (MovieBrowser.DataModel.Genre)item;
            collection.Add(newItem);
        }

        private void VectorAdd_5_ObservableCollection(object instance, object item)
        {
            var collection = (System.Collections.Generic.ICollection<MovieBrowser.DataModel.Title>)instance;
            var newItem = (MovieBrowser.DataModel.Title)item;
            collection.Add(newItem);
        }

        private void VectorAdd_6_Collection(object instance, object item)
        {
            var collection = (System.Collections.Generic.ICollection<MovieBrowser.DataModel.Title>)instance;
            var newItem = (MovieBrowser.DataModel.Title)item;
            collection.Add(newItem);
        }


        private IXamlType CreateXamlType(string typeName)
        {
            XamlSystemBaseType xamlType = null;
            XamlUserType userType;

            switch (typeName)
            {
            case "Object":
                xamlType = new XamlSystemBaseType(typeName, typeof(System.Object));
                break;

            case "String":
                xamlType = new XamlSystemBaseType(typeName, typeof(System.String));
                break;

            case "Windows.UI.Xaml.Controls.Page":
                xamlType = new XamlSystemBaseType(typeName, typeof(Windows.UI.Xaml.Controls.Page));
                break;

            case "Windows.UI.Xaml.Controls.UserControl":
                xamlType = new XamlSystemBaseType(typeName, typeof(Windows.UI.Xaml.Controls.UserControl));
                break;

            case "MovieBrowser.DataModel.MovieBrowserViewModel":
                userType = new XamlUserType(this, typeName, typeof(MovieBrowser.DataModel.MovieBrowserViewModel), GetXamlTypeByName("MovieBrowser.Common.BindableBase"));
                userType.Activator = Activate_0_MovieBrowserViewModel;
                userType.AddMemberName("Genres");
                AddToMapOfTypeToStandardName(typeof(System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Genre>),
                                                   "System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Genre>");
                userType.AddMemberName("SelectedGenre");
                userType.AddMemberName("SelectedTitle");
                userType.AddMemberName("SelectTitleCommand");
                userType.AddMemberName("SelectGenreCommand");
                xamlType = userType;
                break;

            case "MovieBrowser.Common.BindableBase":
                userType = new XamlUserType(this, typeName, typeof(MovieBrowser.Common.BindableBase), GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case "System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Genre>":
                userType = new XamlUserType(this, typeName, typeof(System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Genre>), GetXamlTypeByName("System.Collections.ObjectModel.Collection<MovieBrowser.DataModel.Genre>"));
                AddToMapOfTypeToStandardName(typeof(System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Genre>),
                                                   "System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Genre>");
                userType.Activator = Activate_2_ObservableCollection;
                userType.CollectionAdd = VectorAdd_2_ObservableCollection;
                xamlType = userType;
                break;

            case "System.Collections.ObjectModel.Collection<MovieBrowser.DataModel.Genre>":
                userType = new XamlUserType(this, typeName, typeof(System.Collections.ObjectModel.Collection<MovieBrowser.DataModel.Genre>), GetXamlTypeByName("Object"));
                AddToMapOfTypeToStandardName(typeof(System.Collections.ObjectModel.Collection<MovieBrowser.DataModel.Genre>),
                                                   "System.Collections.ObjectModel.Collection<MovieBrowser.DataModel.Genre>");
                userType.Activator = Activate_3_Collection;
                userType.CollectionAdd = VectorAdd_3_Collection;
                xamlType = userType;
                break;

            case "MovieBrowser.DataModel.Genre":
                userType = new XamlUserType(this, typeName, typeof(MovieBrowser.DataModel.Genre), GetXamlTypeByName("MovieBrowser.Common.BindableBase"));
                userType.Activator = Activate_4_Genre;
                userType.AddMemberName("Name");
                AddToMapOfTypeToStandardName(typeof(System.String),
                                                   "String");
                userType.AddMemberName("Titles");
                AddToMapOfTypeToStandardName(typeof(System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Title>),
                                                   "System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Title>");
                xamlType = userType;
                break;

            case "System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Title>":
                userType = new XamlUserType(this, typeName, typeof(System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Title>), GetXamlTypeByName("System.Collections.ObjectModel.Collection<MovieBrowser.DataModel.Title>"));
                AddToMapOfTypeToStandardName(typeof(System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Title>),
                                                   "System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Title>");
                userType.Activator = Activate_5_ObservableCollection;
                userType.CollectionAdd = VectorAdd_5_ObservableCollection;
                xamlType = userType;
                break;

            case "System.Collections.ObjectModel.Collection<MovieBrowser.DataModel.Title>":
                userType = new XamlUserType(this, typeName, typeof(System.Collections.ObjectModel.Collection<MovieBrowser.DataModel.Title>), GetXamlTypeByName("Object"));
                AddToMapOfTypeToStandardName(typeof(System.Collections.ObjectModel.Collection<MovieBrowser.DataModel.Title>),
                                                   "System.Collections.ObjectModel.Collection<MovieBrowser.DataModel.Title>");
                userType.Activator = Activate_6_Collection;
                userType.CollectionAdd = VectorAdd_6_Collection;
                xamlType = userType;
                break;

            case "MovieBrowser.DataModel.Title":
                userType = new XamlUserType(this, typeName, typeof(MovieBrowser.DataModel.Title), GetXamlTypeByName("MovieBrowser.Common.BindableBase"));
                userType.Activator = Activate_7_Title;
                userType.AddMemberName("Name");
                AddToMapOfTypeToStandardName(typeof(System.String),
                                                   "String");
                userType.AddMemberName("ShortName");
                AddToMapOfTypeToStandardName(typeof(System.String),
                                                   "String");
                userType.AddMemberName("Synopsis");
                AddToMapOfTypeToStandardName(typeof(System.String),
                                                   "String");
                userType.AddMemberName("ShortSynopsis");
                AddToMapOfTypeToStandardName(typeof(System.String),
                                                   "String");
                userType.AddMemberName("BoxArt");
                xamlType = userType;
                break;

            case "MovieBrowser.DataModel.BoxArt":
                userType = new XamlUserType(this, typeName, typeof(MovieBrowser.DataModel.BoxArt), GetXamlTypeByName("MovieBrowser.Common.BindableBase"));
                userType.Activator = Activate_8_BoxArt;
                xamlType = userType;
                break;

            case "System.Windows.Input.ICommand":
                userType = new XamlUserType(this, typeName, typeof(System.Windows.Input.ICommand), null);
                xamlType = userType;
                break;

            case "MovieBrowser.Common.LayoutAwarePage":
                userType = new XamlUserType(this, typeName, typeof(MovieBrowser.Common.LayoutAwarePage), GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_LayoutAwarePage;
                xamlType = userType;
                break;

            case "MovieBrowser.GroupedItemsPage":
                userType = new XamlUserType(this, typeName, typeof(MovieBrowser.GroupedItemsPage), GetXamlTypeByName("MovieBrowser.Common.LayoutAwarePage"));
                userType.Activator = Activate_11_GroupedItemsPage;
                xamlType = userType;
                break;

            case "MovieBrowser.GroupDetailPage":
                userType = new XamlUserType(this, typeName, typeof(MovieBrowser.GroupDetailPage), GetXamlTypeByName("MovieBrowser.Common.LayoutAwarePage"));
                userType.Activator = Activate_12_GroupDetailPage;
                xamlType = userType;
                break;

            case "MovieBrowser.ItemDetailPage":
                userType = new XamlUserType(this, typeName, typeof(MovieBrowser.ItemDetailPage), GetXamlTypeByName("MovieBrowser.Common.LayoutAwarePage"));
                userType.Activator = Activate_13_ItemDetailPage;
                xamlType = userType;
                break;

            }
            return xamlType;
        }


        private object get_0_MovieBrowserViewModel_Genres(object instance)
        {
            var that = (MovieBrowser.DataModel.MovieBrowserViewModel)instance;
            return that.Genres;
        }
        private object get_1_Genre_Name(object instance)
        {
            var that = (MovieBrowser.DataModel.Genre)instance;
            return that.Name;
        }
        private void set_1_Genre_Name(object instance, object Value)
        {
            var that = (MovieBrowser.DataModel.Genre)instance;
            that.Name = (System.String)Value;
        }
        private object get_2_Genre_Titles(object instance)
        {
            var that = (MovieBrowser.DataModel.Genre)instance;
            return that.Titles;
        }
        private void set_2_Genre_Titles(object instance, object Value)
        {
            var that = (MovieBrowser.DataModel.Genre)instance;
            that.Titles = (System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Title>)Value;
        }
        private object get_3_Title_Name(object instance)
        {
            var that = (MovieBrowser.DataModel.Title)instance;
            return that.Name;
        }
        private void set_3_Title_Name(object instance, object Value)
        {
            var that = (MovieBrowser.DataModel.Title)instance;
            that.Name = (System.String)Value;
        }
        private object get_4_Title_ShortName(object instance)
        {
            var that = (MovieBrowser.DataModel.Title)instance;
            return that.ShortName;
        }
        private void set_4_Title_ShortName(object instance, object Value)
        {
            var that = (MovieBrowser.DataModel.Title)instance;
            that.ShortName = (System.String)Value;
        }
        private object get_5_Title_Synopsis(object instance)
        {
            var that = (MovieBrowser.DataModel.Title)instance;
            return that.Synopsis;
        }
        private void set_5_Title_Synopsis(object instance, object Value)
        {
            var that = (MovieBrowser.DataModel.Title)instance;
            that.Synopsis = (System.String)Value;
        }
        private object get_6_Title_ShortSynopsis(object instance)
        {
            var that = (MovieBrowser.DataModel.Title)instance;
            return that.ShortSynopsis;
        }
        private void set_6_Title_ShortSynopsis(object instance, object Value)
        {
            var that = (MovieBrowser.DataModel.Title)instance;
            that.ShortSynopsis = (System.String)Value;
        }
        private object get_7_Title_BoxArt(object instance)
        {
            var that = (MovieBrowser.DataModel.Title)instance;
            return that.BoxArt;
        }
        private void set_7_Title_BoxArt(object instance, object Value)
        {
            var that = (MovieBrowser.DataModel.Title)instance;
            that.BoxArt = (MovieBrowser.DataModel.BoxArt)Value;
        }
        private object get_8_MovieBrowserViewModel_SelectedGenre(object instance)
        {
            var that = (MovieBrowser.DataModel.MovieBrowserViewModel)instance;
            return that.SelectedGenre;
        }
        private void set_8_MovieBrowserViewModel_SelectedGenre(object instance, object Value)
        {
            var that = (MovieBrowser.DataModel.MovieBrowserViewModel)instance;
            that.SelectedGenre = (MovieBrowser.DataModel.Genre)Value;
        }
        private object get_9_MovieBrowserViewModel_SelectedTitle(object instance)
        {
            var that = (MovieBrowser.DataModel.MovieBrowserViewModel)instance;
            return that.SelectedTitle;
        }
        private void set_9_MovieBrowserViewModel_SelectedTitle(object instance, object Value)
        {
            var that = (MovieBrowser.DataModel.MovieBrowserViewModel)instance;
            that.SelectedTitle = (MovieBrowser.DataModel.Title)Value;
        }
        private object get_10_MovieBrowserViewModel_SelectTitleCommand(object instance)
        {
            var that = (MovieBrowser.DataModel.MovieBrowserViewModel)instance;
            return that.SelectTitleCommand;
        }
        private object get_11_MovieBrowserViewModel_SelectGenreCommand(object instance)
        {
            var that = (MovieBrowser.DataModel.MovieBrowserViewModel)instance;
            return that.SelectGenreCommand;
        }

        private IXamlMember CreateXamlMember(string longMemberName)
        {
            XamlMember xamlMember = null;
            XamlUserType userType;

            switch (longMemberName)
            {
            case "MovieBrowser.DataModel.MovieBrowserViewModel.Genres":
                userType = (XamlUserType)GetXamlTypeByName("MovieBrowser.DataModel.MovieBrowserViewModel");
                xamlMember = new XamlMember(this, "Genres", "System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Genre>");
                xamlMember.Getter = get_0_MovieBrowserViewModel_Genres;
                xamlMember.SetIsReadOnly();
                break;
            case "MovieBrowser.DataModel.Genre.Name":
                userType = (XamlUserType)GetXamlTypeByName("MovieBrowser.DataModel.Genre");
                xamlMember = new XamlMember(this, "Name", "String");
                xamlMember.Getter = get_1_Genre_Name;
                xamlMember.Setter = set_1_Genre_Name;
                break;
            case "MovieBrowser.DataModel.Genre.Titles":
                userType = (XamlUserType)GetXamlTypeByName("MovieBrowser.DataModel.Genre");
                xamlMember = new XamlMember(this, "Titles", "System.Collections.ObjectModel.ObservableCollection<MovieBrowser.DataModel.Title>");
                xamlMember.Getter = get_2_Genre_Titles;
                xamlMember.Setter = set_2_Genre_Titles;
                break;
            case "MovieBrowser.DataModel.Title.Name":
                userType = (XamlUserType)GetXamlTypeByName("MovieBrowser.DataModel.Title");
                xamlMember = new XamlMember(this, "Name", "String");
                xamlMember.Getter = get_3_Title_Name;
                xamlMember.Setter = set_3_Title_Name;
                break;
            case "MovieBrowser.DataModel.Title.ShortName":
                userType = (XamlUserType)GetXamlTypeByName("MovieBrowser.DataModel.Title");
                xamlMember = new XamlMember(this, "ShortName", "String");
                xamlMember.Getter = get_4_Title_ShortName;
                xamlMember.Setter = set_4_Title_ShortName;
                break;
            case "MovieBrowser.DataModel.Title.Synopsis":
                userType = (XamlUserType)GetXamlTypeByName("MovieBrowser.DataModel.Title");
                xamlMember = new XamlMember(this, "Synopsis", "String");
                xamlMember.Getter = get_5_Title_Synopsis;
                xamlMember.Setter = set_5_Title_Synopsis;
                break;
            case "MovieBrowser.DataModel.Title.ShortSynopsis":
                userType = (XamlUserType)GetXamlTypeByName("MovieBrowser.DataModel.Title");
                xamlMember = new XamlMember(this, "ShortSynopsis", "String");
                xamlMember.Getter = get_6_Title_ShortSynopsis;
                xamlMember.Setter = set_6_Title_ShortSynopsis;
                break;
            case "MovieBrowser.DataModel.Title.BoxArt":
                userType = (XamlUserType)GetXamlTypeByName("MovieBrowser.DataModel.Title");
                xamlMember = new XamlMember(this, "BoxArt", "MovieBrowser.DataModel.BoxArt");
                xamlMember.Getter = get_7_Title_BoxArt;
                xamlMember.Setter = set_7_Title_BoxArt;
                break;
            case "MovieBrowser.DataModel.MovieBrowserViewModel.SelectedGenre":
                userType = (XamlUserType)GetXamlTypeByName("MovieBrowser.DataModel.MovieBrowserViewModel");
                xamlMember = new XamlMember(this, "SelectedGenre", "MovieBrowser.DataModel.Genre");
                xamlMember.Getter = get_8_MovieBrowserViewModel_SelectedGenre;
                xamlMember.Setter = set_8_MovieBrowserViewModel_SelectedGenre;
                break;
            case "MovieBrowser.DataModel.MovieBrowserViewModel.SelectedTitle":
                userType = (XamlUserType)GetXamlTypeByName("MovieBrowser.DataModel.MovieBrowserViewModel");
                xamlMember = new XamlMember(this, "SelectedTitle", "MovieBrowser.DataModel.Title");
                xamlMember.Getter = get_9_MovieBrowserViewModel_SelectedTitle;
                xamlMember.Setter = set_9_MovieBrowserViewModel_SelectedTitle;
                break;
            case "MovieBrowser.DataModel.MovieBrowserViewModel.SelectTitleCommand":
                userType = (XamlUserType)GetXamlTypeByName("MovieBrowser.DataModel.MovieBrowserViewModel");
                xamlMember = new XamlMember(this, "SelectTitleCommand", "System.Windows.Input.ICommand");
                xamlMember.Getter = get_10_MovieBrowserViewModel_SelectTitleCommand;
                xamlMember.SetIsReadOnly();
                break;
            case "MovieBrowser.DataModel.MovieBrowserViewModel.SelectGenreCommand":
                userType = (XamlUserType)GetXamlTypeByName("MovieBrowser.DataModel.MovieBrowserViewModel");
                xamlMember = new XamlMember(this, "SelectGenreCommand", "System.Windows.Input.ICommand");
                xamlMember.Getter = get_11_MovieBrowserViewModel_SelectGenreCommand;
                xamlMember.SetIsReadOnly();
                break;
            }
            return xamlMember;
        }

    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : IXamlType
    {
        string _fullName;
        Type _underlyingType;

        public XamlSystemBaseType(string fullName, Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public IXamlType BaseType { get { throw new NotImplementedException(); } }
        virtual public IXamlMember ContentProperty { get { throw new NotImplementedException(); } }
        virtual public IXamlMember GetMember(string name) { throw new NotImplementedException(); }
        virtual public bool IsArray { get { throw new NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new NotImplementedException(); } }
        virtual public IXamlType ItemType { get { throw new NotImplementedException(); } }
        virtual public IXamlType KeyType { get { throw new NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new NotImplementedException(); }
        virtual public void RunInitializer()   { throw new NotImplementedException(); }
        virtual public object CreateFromString(String input)   { throw new NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : XamlSystemBaseType
    {
        XamlTypeInfoProvider _provider;
        IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        Dictionary<string, string> _memberNames;
        Dictionary<string, object> _enumValues;

        public XamlUserType(XamlTypeInfoProvider provider, string fullName, Type fullType, IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }

        override public IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public IXamlMember GetMember(string name)
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

        override public Object CreateFromString(String input)
        {
            if (_enumValues != null)
            {
                Int32 value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    Int32 enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = Convert.ToInt32(valuePart.Trim());
                            }
                            catch( FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( String.Compare(valuePart.Trim(), key, System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( FormatException )
                    {
                        throw new ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new ArgumentException(input, FullName);
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
                _memberNames =  new Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : IXamlMember
    {
        XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(String targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public IXamlType TargetType
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
                throw new InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new InvalidOperationException("SetValue");
        }
    }
}


