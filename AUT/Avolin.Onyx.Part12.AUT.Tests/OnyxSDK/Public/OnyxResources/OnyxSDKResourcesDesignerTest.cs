using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.OnyxResources;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.OnyxResources
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OnyxResources.OnyxSDKResources" />)
    ///     and namespace <see cref="OnyxSDK.Public.OnyxResources"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxSDKResourcesDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxSDKResources" />)
        /// </summary>
        public OnyxSDKResourcesDesignerTest() : base(typeof(OnyxSDKResources))
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

        #region General Initializer : Class (OnyxSDKResources) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxSDKResourcesInstanceType;
        private OnyxSDKResources _onyxSDKResourcesInstance;
        private OnyxSDKResources _onyxSDKResourcesInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxSDKResources" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxSDKResourcesInstanceType = typeof(OnyxSDKResources);
            _onyxSDKResourcesInstanceFixture = this.Create<OnyxSDKResources>(false);
            _onyxSDKResourcesInstance = _onyxSDKResourcesInstanceFixture ?? this.Create<OnyxSDKResources>(true);
            CurrentInstance = _onyxSDKResourcesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxSDKResources) Initializer

        #region Properties

        private const string PropertyResourceManager = "ResourceManager";
        private const string PropertyCulture = "Culture";
        private const string PropertyCLEAR_SESSION_ITEMS = "CLEAR_SESSION_ITEMS";
        private const string PropertyCREATE_SESSION_EXCEPTION = "CREATE_SESSION_EXCEPTION";
        private const string PropertyEND_SESSION = "END_SESSION";
        private const string PropertyGET_CONGIGURED_EXCEPTION = "GET_CONGIGURED_EXCEPTION";
        private const string PropertyHASPERMISSION_EXCEPTION = "HASPERMISSION_EXCEPTION";
        private const string PropertyOPM_LICENSE_EXCEPTION = "OPM_LICENSE_EXCEPTION";
        private const string PropertyPASSWORD_CHANGE_EXCEPTION = "PASSWORD_CHANGE_EXCEPTION";
        private const string PropertyTHREW_ERROR_OBJECT = "THREW_ERROR_OBJECT";
        private const string PropertyUNABLE_CONTEXT_XML = "UNABLE_CONTEXT_XML";
        private const string PropertyUNABLE_REMOVE_SESSION_ITEM = "UNABLE_REMOVE_SESSION_ITEM";
        private const string PropertyUNABLE_SESSION_ITEM = "UNABLE_SESSION_ITEM";
        private const string PropertyUNABLE_SESSION_ITEMS = "UNABLE_SESSION_ITEMS";
        private const string PropertyUNABLE_SET_SESSION_ITEM = "UNABLE_SET_SESSION_ITEM";
        private const string PropertyUNABLE_TO_EXECUTE_CALL = "UNABLE_TO_EXECUTE_CALL";
        private const string PropertyUNABLE_TO_IMPERSONATE = "UNABLE_TO_IMPERSONATE";
        private const string PropertyUNABLE_TO_LOAD_OBJECT = "UNABLE_TO_LOAD_OBJECT";
        private const string PropertyUNABLE_TOGET_NATLANG = "UNABLE_TOGET_NATLANG";
        private const string PropertyUNABLE_TRANSACTION_EXECUTE = "UNABLE_TRANSACTION_EXECUTE";

        #endregion

        #region Fields

        private const string FieldresourceMan = "resourceMan";
        private const string FieldresourceCulture = "resourceCulture";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxSDKResources) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxSDKResources" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSDKResourcesDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxSDKResources) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxSDKResources" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSDKResourcesDesigner_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxSDKResources) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxSDKResources" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSDKResourcesDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxSDKResources)

        #region General Initializer : Class (OnyxSDKResources) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxSDKResources" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyResourceManager)]
        [TestCase(PropertyCulture)]
        [TestCase(PropertyCLEAR_SESSION_ITEMS)]
        [TestCase(PropertyCREATE_SESSION_EXCEPTION)]
        [TestCase(PropertyEND_SESSION)]
        [TestCase(PropertyGET_CONGIGURED_EXCEPTION)]
        [TestCase(PropertyHASPERMISSION_EXCEPTION)]
        [TestCase(PropertyOPM_LICENSE_EXCEPTION)]
        [TestCase(PropertyPASSWORD_CHANGE_EXCEPTION)]
        [TestCase(PropertyTHREW_ERROR_OBJECT)]
        [TestCase(PropertyUNABLE_CONTEXT_XML)]
        [TestCase(PropertyUNABLE_REMOVE_SESSION_ITEM)]
        [TestCase(PropertyUNABLE_SESSION_ITEM)]
        [TestCase(PropertyUNABLE_SESSION_ITEMS)]
        [TestCase(PropertyUNABLE_SET_SESSION_ITEM)]
        [TestCase(PropertyUNABLE_TO_EXECUTE_CALL)]
        [TestCase(PropertyUNABLE_TO_IMPERSONATE)]
        [TestCase(PropertyUNABLE_TO_LOAD_OBJECT)]
        [TestCase(PropertyUNABLE_TOGET_NATLANG)]
        [TestCase(PropertyUNABLE_TRANSACTION_EXECUTE)]
        [Category("AUT Property")]
        public void AUT_OnyxSDKResourcesDesigner_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxSDKResources) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxSDKResources" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldresourceMan)]
        [TestCase(FieldresourceCulture)]
        [Category("AUT Fields")]
        public void AUT_OnyxSDKResourcesDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (OnyxSDKResources) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxSDKResources" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxSDKResourcesDesigner_Is_Instance_Present_Test()
        {
            // Assert
            _onyxSDKResourcesInstanceType.ShouldNotBeNull();
            _onyxSDKResourcesInstance.ShouldNotBeNull();
            _onyxSDKResourcesInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxSDKResources) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxSDKResources" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxSDKResourcesDesigner_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxSDKResourcesInstance.ShouldBeAssignableTo<OnyxSDKResources>();
            _onyxSDKResourcesInstanceFixture.ShouldBeAssignableTo<OnyxSDKResources>();
            CurrentInstance.ShouldBeAssignableTo<OnyxSDKResources>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxSDKResources) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyResourceManager)]
        [TestCase(PropertyCulture)]
        [TestCase(PropertyCLEAR_SESSION_ITEMS)]
        [TestCase(PropertyCREATE_SESSION_EXCEPTION)]
        [TestCase(PropertyEND_SESSION)]
        [TestCase(PropertyGET_CONGIGURED_EXCEPTION)]
        [TestCase(PropertyHASPERMISSION_EXCEPTION)]
        [TestCase(PropertyOPM_LICENSE_EXCEPTION)]
        [TestCase(PropertyPASSWORD_CHANGE_EXCEPTION)]
        [TestCase(PropertyTHREW_ERROR_OBJECT)]
        [TestCase(PropertyUNABLE_CONTEXT_XML)]
        [TestCase(PropertyUNABLE_REMOVE_SESSION_ITEM)]
        [TestCase(PropertyUNABLE_SESSION_ITEM)]
        [TestCase(PropertyUNABLE_SESSION_ITEMS)]
        [TestCase(PropertyUNABLE_SET_SESSION_ITEM)]
        [TestCase(PropertyUNABLE_TO_EXECUTE_CALL)]
        [TestCase(PropertyUNABLE_TO_IMPERSONATE)]
        [TestCase(PropertyUNABLE_TO_LOAD_OBJECT)]
        [TestCase(PropertyUNABLE_TOGET_NATLANG)]
        [TestCase(PropertyUNABLE_TRANSACTION_EXECUTE)]
        public void AUT_OnyxSDKResourcesDesigner_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (CLEAR_SESSION_ITEMS) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_CLEAR_SESSION_ITEMS_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCLEAR_SESSION_ITEMS);
            var propertyInfo = this.GetPropertyInfo(PropertyCLEAR_SESSION_ITEMS);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (CREATE_SESSION_EXCEPTION) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_CREATE_SESSION_EXCEPTION_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCREATE_SESSION_EXCEPTION);
            var propertyInfo = this.GetPropertyInfo(PropertyCREATE_SESSION_EXCEPTION);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (Culture) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Culture_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCulture);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCulture);
            Action currentAction = () => propertyInfo.SetValue(_onyxSDKResourcesInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (Culture) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_Culture_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCulture);
            var propertyInfo = this.GetPropertyInfo(PropertyCulture);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (END_SESSION) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_END_SESSION_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEND_SESSION);
            var propertyInfo = this.GetPropertyInfo(PropertyEND_SESSION);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (GET_CONGIGURED_EXCEPTION) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_GET_CONGIGURED_EXCEPTION_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyGET_CONGIGURED_EXCEPTION);
            var propertyInfo = this.GetPropertyInfo(PropertyGET_CONGIGURED_EXCEPTION);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (HASPERMISSION_EXCEPTION) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_HASPERMISSION_EXCEPTION_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHASPERMISSION_EXCEPTION);
            var propertyInfo = this.GetPropertyInfo(PropertyHASPERMISSION_EXCEPTION);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (OPM_LICENSE_EXCEPTION) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_OPM_LICENSE_EXCEPTION_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOPM_LICENSE_EXCEPTION);
            var propertyInfo = this.GetPropertyInfo(PropertyOPM_LICENSE_EXCEPTION);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (PASSWORD_CHANGE_EXCEPTION) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_PASSWORD_CHANGE_EXCEPTION_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPASSWORD_CHANGE_EXCEPTION);
            var propertyInfo = this.GetPropertyInfo(PropertyPASSWORD_CHANGE_EXCEPTION);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (ResourceManager) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_ResourceManager_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceManager);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyResourceManager);
            Action currentAction = () => propertyInfo.SetValue(_onyxSDKResourcesInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (ResourceManager) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_ResourceManager_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceManager);
            var propertyInfo = this.GetPropertyInfo(PropertyResourceManager);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (THREW_ERROR_OBJECT) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_THREW_ERROR_OBJECT_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTHREW_ERROR_OBJECT);
            var propertyInfo = this.GetPropertyInfo(PropertyTHREW_ERROR_OBJECT);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (UNABLE_CONTEXT_XML) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_UNABLE_CONTEXT_XML_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUNABLE_CONTEXT_XML);
            var propertyInfo = this.GetPropertyInfo(PropertyUNABLE_CONTEXT_XML);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (UNABLE_REMOVE_SESSION_ITEM) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_UNABLE_REMOVE_SESSION_ITEM_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUNABLE_REMOVE_SESSION_ITEM);
            var propertyInfo = this.GetPropertyInfo(PropertyUNABLE_REMOVE_SESSION_ITEM);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (UNABLE_SESSION_ITEM) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_UNABLE_SESSION_ITEM_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUNABLE_SESSION_ITEM);
            var propertyInfo = this.GetPropertyInfo(PropertyUNABLE_SESSION_ITEM);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (UNABLE_SESSION_ITEMS) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_UNABLE_SESSION_ITEMS_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUNABLE_SESSION_ITEMS);
            var propertyInfo = this.GetPropertyInfo(PropertyUNABLE_SESSION_ITEMS);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (UNABLE_SET_SESSION_ITEM) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_UNABLE_SET_SESSION_ITEM_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUNABLE_SET_SESSION_ITEM);
            var propertyInfo = this.GetPropertyInfo(PropertyUNABLE_SET_SESSION_ITEM);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (UNABLE_TO_EXECUTE_CALL) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_UNABLE_TO_EXECUTE_CALL_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUNABLE_TO_EXECUTE_CALL);
            var propertyInfo = this.GetPropertyInfo(PropertyUNABLE_TO_EXECUTE_CALL);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (UNABLE_TO_IMPERSONATE) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_UNABLE_TO_IMPERSONATE_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUNABLE_TO_IMPERSONATE);
            var propertyInfo = this.GetPropertyInfo(PropertyUNABLE_TO_IMPERSONATE);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (UNABLE_TO_LOAD_OBJECT) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_UNABLE_TO_LOAD_OBJECT_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUNABLE_TO_LOAD_OBJECT);
            var propertyInfo = this.GetPropertyInfo(PropertyUNABLE_TO_LOAD_OBJECT);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (UNABLE_TOGET_NATLANG) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_UNABLE_TOGET_NATLANG_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUNABLE_TOGET_NATLANG);
            var propertyInfo = this.GetPropertyInfo(PropertyUNABLE_TOGET_NATLANG);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSDKResources) => Property (UNABLE_TRANSACTION_EXECUTE) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSDKResourcesDesigner_Public_Class_UNABLE_TRANSACTION_EXECUTE_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUNABLE_TRANSACTION_EXECUTE);
            var propertyInfo = this.GetPropertyInfo(PropertyUNABLE_TRANSACTION_EXECUTE);

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