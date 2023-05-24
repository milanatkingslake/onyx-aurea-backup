using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxDictionaryDAC;
using Shouldly;

namespace Avolin.Onyx.Part05.AUT.Tests.OnyxDictionaryDAC
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxDictionaryDAC.DOMHelper" />)
    ///     and namespace <see cref="OnyxDictionaryDAC"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DOMHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="DOMHelperNonPublicTypeName" />) using
        ///     Using a public type <see cref="Dictionary" /> to
        ///     create a non-public type.
        /// </summary>
        public DOMHelperTest() : base(publicType: typeof(Dictionary), classNameWithNamespace: DOMHelperNonPublicTypeName)
        { }

        #region Category : General

        #region Category : Initializer

        #region General Initializer : Overrides of IBaseSetupV1Test

        /// <summary>
        ///    Configure and ignore problematic tests.
        ///    Added tests will be ignored.
        /// </summary>
        public override void ConfigureIgnoringTests()
        {
            base.ConfigureIgnoringTests();
        }

        #endregion

        private Type _dOMHelperInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string DOMHelperNonPublicTypeName = "OnyxDictionaryDAC.DOMHelper";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _dOMHelperInstance;
        private object _dOMHelperInstanceFixture;

        #region General Initializer : Class (DOMHelper) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="DOMHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dOMHelperInstanceFixture = this.CreateNonPublicType(DOMHelperNonPublicTypeName);
            _dOMHelperInstance = _dOMHelperInstanceFixture;
            CurrentInstance = _dOMHelperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DOMHelper) Initializer

        #region Properties

        private const string PropertyDOM = "DOM";
        private const string PropertyTopNode = "TopNode";
        private const string PropertyXML = "XML";
        private const string PropertyIsCollection = "IsCollection";
        private const string PropertyObjectType = "ObjectType";

        #endregion

        #region Methods

        private const string MethodLoadXML = "LoadXML";
        private const string MethodAttach = "Attach";
        private const string MethodDetach = "Detach";
        private const string MethodAddCollectionNodeToBO = "AddCollectionNodeToBO";
        private const string MethodGetAttributeString = "GetAttributeString";
        private const string MethodGetAttributeBoolean = "GetAttributeBoolean";
        private const string MethodSetAttributeString = "SetAttributeString";
        private const string MethodSetAttributeBoolean = "SetAttributeBoolean";
        private const string MethodRemoveAttribute = "RemoveAttribute";
        private const string MethodGetProperty = "GetProperty";
        private const string MethodGetPropertyWithDefault = "GetPropertyWithDefault";
        private const string MethodSetProperty = "SetProperty";
        private const string MethodGetPropertyObject = "GetPropertyObject";
        private const string MethodRemoveAll = "RemoveAll";
        private const string MethodSetPropertyObject = "SetPropertyObject";
        private const string MethodSetPropertyObjectClone = "SetPropertyObjectClone";
        private const string MethodSetPropertyObjectCloneFromXML = "SetPropertyObjectCloneFromXML";
        private const string MethodGetFirstItem = "GetFirstItem";
        private const string MethodGetNextItem = "GetNextItem";
        private const string MethodSetCurrentItem = "SetCurrentItem";
        private const string MethodDeleteCurrentItem = "DeleteCurrentItem";
        private const string MethodGetFirstItemObject = "GetFirstItemObject";
        private const string MethodGetNextItemObject = "GetNextItemObject";
        private const string MethodSetCurrentItemObject = "SetCurrentItemObject";
        private const string MethodSetCurrentItemObjectClone = "SetCurrentItemObjectClone";
        private const string MethodSetCurrentItemObjectCloneFromXML = "SetCurrentItemObjectCloneFromXML";
        private const string MethodCreateElementWithNamespace = "CreateElementWithNamespace";
        
        private const string MethodGetNodeAttributeString = "GetNodeAttributeString";
        private const string MethodGetNodeAttributeBoolean = "GetNodeAttributeBoolean";
        private const string MethodSetNodeAttributeString = "SetNodeAttributeString";
        private const string MethodSetNodeAttributeBoolean = "SetNodeAttributeBoolean";
        private const string MethodRemoveNodeAttribute = "RemoveNodeAttribute";
        private const string MethodGetPropertySimple = "GetPropertySimple";
        private const string MethodCopyNodeRecursive = "CopyNodeRecursive";

        #endregion

        #region Fields

        private const string FieldTAG_NULL = "TAG_NULL";
        private const string FieldTAG_COLLECTION = "TAG_COLLECTION";
        private const string FieldTAG_OBJECTTYPE = "TAG_OBJECTTYPE";
        private const string FieldTAG_BOOLEAN_FALSE = "TAG_BOOLEAN_FALSE";
        private const string FieldTAG_BOOLEAN_TRUE = "TAG_BOOLEAN_TRUE";
        private const string FieldPROPERTY_DATETIME_FORMAT = "PROPERTY_DATETIME_FORMAT";
        private const string FieldmoDOM = "moDOM";
        private const string FieldmoTopNode = "moTopNode";
        private const string FieldmoItemNode = "moItemNode";
        private const string FieldmsObjectType = "msObjectType";
        private const string FieldmbCollection = "mbCollection";
        private const string FieldmbUseNamespaces = "mbUseNamespaces";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (DOMHelper)

        #region General Initializer : Class (DOMHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DOMHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLoadXML, 0)]
        [TestCase(MethodAttach, 0)]
        [TestCase(MethodDetach, 0)]
        [TestCase(MethodAddCollectionNodeToBO, 0)]
        [TestCase(MethodGetAttributeString, 0)]
        [TestCase(MethodGetAttributeBoolean, 0)]
        [TestCase(MethodSetAttributeString, 0)]
        [TestCase(MethodSetAttributeBoolean, 0)]
        [TestCase(MethodRemoveAttribute, 0)]
        [TestCase(MethodGetProperty, 0)]
        [TestCase(MethodGetPropertyWithDefault, 0)]
        [TestCase(MethodSetProperty, 0)]
        [TestCase(MethodGetPropertyObject, 0)]
        [TestCase(MethodRemoveAll, 0)]
        [TestCase(MethodSetPropertyObject, 0)]
        [TestCase(MethodSetPropertyObjectClone, 0)]
        [TestCase(MethodSetPropertyObjectCloneFromXML, 0)]
        [TestCase(MethodGetFirstItem, 0)]
        [TestCase(MethodGetNextItem, 0)]
        [TestCase(MethodSetCurrentItem, 0)]
        [TestCase(MethodDeleteCurrentItem, 0)]
        [TestCase(MethodGetFirstItemObject, 0)]
        [TestCase(MethodGetNextItemObject, 0)]
        [TestCase(MethodSetCurrentItemObject, 0)]
        [TestCase(MethodSetCurrentItemObjectClone, 0)]
        [TestCase(MethodSetCurrentItemObjectCloneFromXML, 0)]
        [TestCase(MethodCreateElementWithNamespace, 0)]
        [TestCase(MethodGetNodeAttributeString, 0)]
        [TestCase(MethodGetNodeAttributeBoolean, 0)]
        [TestCase(MethodSetNodeAttributeString, 0)]
        [TestCase(MethodSetNodeAttributeBoolean, 0)]
        [TestCase(MethodRemoveNodeAttribute, 0)]
        [TestCase(MethodGetPropertySimple, 0)]
        [Category("AUT Explore")]
        public void AUT_DOMHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion
        
        #region General Initializer : Class (DOMHelper) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="DOMHelper" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyDOM)]
        [TestCase(PropertyTopNode)]
        [TestCase(PropertyXML)]
        [TestCase(PropertyIsCollection)]
        [TestCase(PropertyObjectType)]
        [Category("AUT Property")]
        public void AUT_DOMHelper_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (DOMHelper) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="DOMHelper" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DOMHelper_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (DOMHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DOMHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldTAG_NULL)]
        [TestCase(FieldTAG_COLLECTION)]
        [TestCase(FieldTAG_OBJECTTYPE)]
        [TestCase(FieldTAG_BOOLEAN_FALSE)]
        [TestCase(FieldTAG_BOOLEAN_TRUE)]
        [TestCase(FieldPROPERTY_DATETIME_FORMAT)]
        [TestCase(FieldmoDOM)]
        [TestCase(FieldmoTopNode)]
        [TestCase(FieldmoItemNode)]
        [TestCase(FieldmsObjectType)]
        [TestCase(FieldmbCollection)]
        [TestCase(FieldmbUseNamespaces)]
        [Category("AUT Fields")]
        public void AUT_DOMHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (DOMHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DOMHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DOMHelper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (DOMHelper) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyDOM)]
        [TestCase(PropertyTopNode)]
        [TestCase(PropertyXML)]
        [TestCase(PropertyIsCollection)]
        [TestCase(PropertyObjectType)]
        public void AUT_DOMHelper_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (DOMHelper) => Property (IsCollection) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DOMHelper_Public_Class_IsCollection_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsCollection);
            var propertyInfo = this.GetPropertyInfo(PropertyIsCollection);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DOMHelper) => Property (ObjectType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DOMHelper_Public_Class_ObjectType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectType);
            var propertyInfo = this.GetPropertyInfo(PropertyObjectType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DOMHelper) => Property (TopNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DOMHelper_TopNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTopNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyTopNode);
            Action currentAction = () => propertyInfo.SetValue(_dOMHelperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (DOMHelper) => Property (TopNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DOMHelper_Public_Class_TopNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTopNode);
            var propertyInfo = this.GetPropertyInfo(PropertyTopNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DOMHelper) => Property (XML) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DOMHelper_Public_Class_XML_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyXML);
            var propertyInfo = this.GetPropertyInfo(PropertyXML);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #endregion
    }
}