using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Resources;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Resources
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Resources.ScriptingUIResource" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Resources"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptingUIResourceDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptingUIResource" />)
        /// </summary>
        public ScriptingUIResourceDesignerTest() : base(typeof(ScriptingUIResource))
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

        #region General Initializer : Class (ScriptingUIResource) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptingUIResourceInstanceType;
        private ScriptingUIResource _scriptingUIResourceInstance;
        private ScriptingUIResource _scriptingUIResourceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptingUIResource" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptingUIResourceInstanceType = typeof(ScriptingUIResource);
            _scriptingUIResourceInstanceFixture = this.Create<ScriptingUIResource>(false);
            _scriptingUIResourceInstance = _scriptingUIResourceInstanceFixture ?? this.Create<ScriptingUIResource>(true);
            CurrentInstance = _scriptingUIResourceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptingUIResource) Initializer

        #region Properties

        private const string PropertyResourceManager = "ResourceManager";
        private const string PropertyCulture = "Culture";
        private const string PropertyUnableToCreateSession = "UnableToCreateSession";
        private const string PropertyUnableToCreateSessionForOeg = "UnableToCreateSessionForOeg";
        private const string PropertyUnableToDeleteScriptSession = "UnableToDeleteScriptSession";
        private const string PropertyUnableToExecutePrintSession = "UnableToExecutePrintSession";
        private const string PropertyUnableToGetActiveProducts = "UnableToGetActiveProducts";
        private const string PropertyUnableToGetActiveUsers = "UnableToGetActiveUsers";
        private const string PropertyUnableToGetCampaignForId = "UnableToGetCampaignForId";
        private const string PropertyUnableToGetCampaignTypeCode = "UnableToGetCampaignTypeCode";
        private const string PropertyUnableToGetIncidentInfo = "UnableToGetIncidentInfo";
        private const string PropertyUnableToGetPreferenceForCurrentUser = "UnableToGetPreferenceForCurrentUser";
        private const string PropertyUnableToGetProductsForCode = "UnableToGetProductsForCode";
        private const string PropertyUnableToGetProductsForParentId = "UnableToGetProductsForParentId";
        private const string PropertyUnableToGetRegion = "UnableToGetRegion";
        private const string PropertyUnableToGetRegionForCountryCode = "UnableToGetRegionForCountryCode";
        private const string PropertyUnableToGetScriptForId = "UnableToGetScriptForId";
        private const string PropertyUnableToGetScriptList = "UnableToGetScriptList";
        private const string PropertyUnableToGetUserForId = "UnableToGetUserForId";
        private const string PropertyUnableToGetUserForSearch = "UnableToGetUserForSearch";
        private const string PropertyUnableToGetUsersForGroup = "UnableToGetUsersForGroup";
        private const string PropertyUnableToLoadApplicationResources = "UnableToLoadApplicationResources";
        private const string PropertyUnableToLoadCountries = "UnableToLoadCountries";
        private const string PropertyUnableToLoadCustomerInfo = "UnableToLoadCustomerInfo";
        private const string PropertyUnableToLoadCustomerSearch = "UnableToLoadCustomerSearch";
        private const string PropertyUnableToLoadMessageLocalizationResources = "UnableToLoadMessageLocalizationResources";
        private const string PropertyUnableToLoadReferenceLookup = "UnableToLoadReferenceLookup";
        private const string PropertyUnableToLoadResources = "UnableToLoadResources";
        private const string PropertyUnableToLoadSecurityResources = "UnableToLoadSecurityResources";
        private const string PropertyUnableToLoadSystemLocalizationResources = "UnableToLoadSystemLocalizationResources";
        private const string PropertyUnableToMoveToStep = "UnableToMoveToStep";
        private const string PropertyUnableToProceedToNextStep = "UnableToProceedToNextStep";
        private const string PropertyUnableToResumeScriptSession = "UnableToResumeScriptSession";
        private const string PropertyUnableToTransform = "UnableToTransform";
        private const string PropertyUnableToUpdateScriptSession = "UnableToUpdateScriptSession";

        #endregion

        #region Fields

        private const string FieldresourceMan = "resourceMan";
        private const string FieldresourceCulture = "resourceCulture";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptingUIResource) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptingUIResource" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptingUIResourceDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptingUIResource) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptingUIResource" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptingUIResourceDesigner_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptingUIResource) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptingUIResource" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptingUIResourceDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptingUIResource)

        #region General Initializer : Class (ScriptingUIResource) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptingUIResource" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyResourceManager)]
        [TestCase(PropertyCulture)]
        [TestCase(PropertyUnableToCreateSession)]
        [TestCase(PropertyUnableToCreateSessionForOeg)]
        [TestCase(PropertyUnableToDeleteScriptSession)]
        [TestCase(PropertyUnableToExecutePrintSession)]
        [TestCase(PropertyUnableToGetActiveProducts)]
        [TestCase(PropertyUnableToGetActiveUsers)]
        [TestCase(PropertyUnableToGetCampaignForId)]
        [TestCase(PropertyUnableToGetCampaignTypeCode)]
        [TestCase(PropertyUnableToGetIncidentInfo)]
        [TestCase(PropertyUnableToGetPreferenceForCurrentUser)]
        [TestCase(PropertyUnableToGetProductsForCode)]
        [TestCase(PropertyUnableToGetProductsForParentId)]
        [TestCase(PropertyUnableToGetRegion)]
        [TestCase(PropertyUnableToGetRegionForCountryCode)]
        [TestCase(PropertyUnableToGetScriptForId)]
        [TestCase(PropertyUnableToGetScriptList)]
        [TestCase(PropertyUnableToGetUserForId)]
        [TestCase(PropertyUnableToGetUserForSearch)]
        [TestCase(PropertyUnableToGetUsersForGroup)]
        [TestCase(PropertyUnableToLoadApplicationResources)]
        [TestCase(PropertyUnableToLoadCountries)]
        [TestCase(PropertyUnableToLoadCustomerInfo)]
        [TestCase(PropertyUnableToLoadCustomerSearch)]
        [TestCase(PropertyUnableToLoadMessageLocalizationResources)]
        [TestCase(PropertyUnableToLoadReferenceLookup)]
        [TestCase(PropertyUnableToLoadResources)]
        [TestCase(PropertyUnableToLoadSecurityResources)]
        [TestCase(PropertyUnableToLoadSystemLocalizationResources)]
        [TestCase(PropertyUnableToMoveToStep)]
        [TestCase(PropertyUnableToProceedToNextStep)]
        [TestCase(PropertyUnableToResumeScriptSession)]
        [TestCase(PropertyUnableToTransform)]
        [TestCase(PropertyUnableToUpdateScriptSession)]
        [Category("AUT Property")]
        public void AUT_ScriptingUIResourceDesigner_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ScriptingUIResource) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptingUIResource" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldresourceMan)]
        [TestCase(FieldresourceCulture)]
        [Category("AUT Fields")]
        public void AUT_ScriptingUIResourceDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptingUIResource) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptingUIResource" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptingUIResourceDesigner_Is_Instance_Present_Test()
        {
            // Assert
            _scriptingUIResourceInstanceType.ShouldNotBeNull();
            _scriptingUIResourceInstance.ShouldNotBeNull();
            _scriptingUIResourceInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptingUIResource) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptingUIResource" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptingUIResourceDesigner_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptingUIResourceInstance.ShouldBeAssignableTo<ScriptingUIResource>();
            _scriptingUIResourceInstanceFixture.ShouldBeAssignableTo<ScriptingUIResource>();
            CurrentInstance.ShouldBeAssignableTo<ScriptingUIResource>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScriptingUIResource) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyResourceManager)]
        [TestCase(PropertyCulture)]
        [TestCase(PropertyUnableToCreateSession)]
        [TestCase(PropertyUnableToCreateSessionForOeg)]
        [TestCase(PropertyUnableToDeleteScriptSession)]
        [TestCase(PropertyUnableToExecutePrintSession)]
        [TestCase(PropertyUnableToGetActiveProducts)]
        [TestCase(PropertyUnableToGetActiveUsers)]
        [TestCase(PropertyUnableToGetCampaignForId)]
        [TestCase(PropertyUnableToGetCampaignTypeCode)]
        [TestCase(PropertyUnableToGetIncidentInfo)]
        [TestCase(PropertyUnableToGetPreferenceForCurrentUser)]
        [TestCase(PropertyUnableToGetProductsForCode)]
        [TestCase(PropertyUnableToGetProductsForParentId)]
        [TestCase(PropertyUnableToGetRegion)]
        [TestCase(PropertyUnableToGetRegionForCountryCode)]
        [TestCase(PropertyUnableToGetScriptForId)]
        [TestCase(PropertyUnableToGetScriptList)]
        [TestCase(PropertyUnableToGetUserForId)]
        [TestCase(PropertyUnableToGetUserForSearch)]
        [TestCase(PropertyUnableToGetUsersForGroup)]
        [TestCase(PropertyUnableToLoadApplicationResources)]
        [TestCase(PropertyUnableToLoadCountries)]
        [TestCase(PropertyUnableToLoadCustomerInfo)]
        [TestCase(PropertyUnableToLoadCustomerSearch)]
        [TestCase(PropertyUnableToLoadMessageLocalizationResources)]
        [TestCase(PropertyUnableToLoadReferenceLookup)]
        [TestCase(PropertyUnableToLoadResources)]
        [TestCase(PropertyUnableToLoadSecurityResources)]
        [TestCase(PropertyUnableToLoadSystemLocalizationResources)]
        [TestCase(PropertyUnableToMoveToStep)]
        [TestCase(PropertyUnableToProceedToNextStep)]
        [TestCase(PropertyUnableToResumeScriptSession)]
        [TestCase(PropertyUnableToTransform)]
        [TestCase(PropertyUnableToUpdateScriptSession)]
        public void AUT_ScriptingUIResourceDesigner_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (Culture) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Culture_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCulture);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCulture);
            Action currentAction = () => propertyInfo.SetValue(_scriptingUIResourceInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (Culture) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_Culture_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (ResourceManager) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_ResourceManager_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceManager);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyResourceManager);
            Action currentAction = () => propertyInfo.SetValue(_scriptingUIResourceInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (ResourceManager) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_ResourceManager_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToCreateSession) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToCreateSession_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToCreateSession);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToCreateSession);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToCreateSessionForOeg) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToCreateSessionForOeg_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToCreateSessionForOeg);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToCreateSessionForOeg);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToDeleteScriptSession) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToDeleteScriptSession_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToDeleteScriptSession);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToDeleteScriptSession);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToExecutePrintSession) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToExecutePrintSession_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToExecutePrintSession);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToExecutePrintSession);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToGetActiveProducts) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToGetActiveProducts_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToGetActiveProducts);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToGetActiveProducts);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToGetActiveUsers) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToGetActiveUsers_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToGetActiveUsers);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToGetActiveUsers);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToGetCampaignForId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToGetCampaignForId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToGetCampaignForId);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToGetCampaignForId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToGetCampaignTypeCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToGetCampaignTypeCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToGetCampaignTypeCode);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToGetCampaignTypeCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToGetIncidentInfo) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToGetIncidentInfo_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToGetIncidentInfo);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToGetIncidentInfo);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToGetPreferenceForCurrentUser) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToGetPreferenceForCurrentUser_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToGetPreferenceForCurrentUser);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToGetPreferenceForCurrentUser);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToGetProductsForCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToGetProductsForCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToGetProductsForCode);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToGetProductsForCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToGetProductsForParentId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToGetProductsForParentId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToGetProductsForParentId);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToGetProductsForParentId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToGetRegion) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToGetRegion_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToGetRegion);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToGetRegion);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToGetRegionForCountryCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToGetRegionForCountryCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToGetRegionForCountryCode);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToGetRegionForCountryCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToGetScriptForId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToGetScriptForId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToGetScriptForId);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToGetScriptForId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToGetScriptList) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToGetScriptList_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToGetScriptList);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToGetScriptList);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToGetUserForId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToGetUserForId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToGetUserForId);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToGetUserForId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToGetUserForSearch) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToGetUserForSearch_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToGetUserForSearch);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToGetUserForSearch);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToGetUsersForGroup) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToGetUsersForGroup_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToGetUsersForGroup);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToGetUsersForGroup);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToLoadApplicationResources) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToLoadApplicationResources_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToLoadApplicationResources);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToLoadApplicationResources);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToLoadCountries) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToLoadCountries_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToLoadCountries);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToLoadCountries);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToLoadCustomerInfo) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToLoadCustomerInfo_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToLoadCustomerInfo);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToLoadCustomerInfo);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToLoadCustomerSearch) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToLoadCustomerSearch_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToLoadCustomerSearch);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToLoadCustomerSearch);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToLoadMessageLocalizationResources) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToLoadMessageLocalizationResources_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToLoadMessageLocalizationResources);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToLoadMessageLocalizationResources);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToLoadReferenceLookup) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToLoadReferenceLookup_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToLoadReferenceLookup);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToLoadReferenceLookup);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToLoadResources) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToLoadResources_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToLoadResources);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToLoadResources);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToLoadSecurityResources) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToLoadSecurityResources_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToLoadSecurityResources);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToLoadSecurityResources);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToLoadSystemLocalizationResources) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToLoadSystemLocalizationResources_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToLoadSystemLocalizationResources);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToLoadSystemLocalizationResources);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToMoveToStep) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToMoveToStep_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToMoveToStep);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToMoveToStep);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToProceedToNextStep) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToProceedToNextStep_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToProceedToNextStep);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToProceedToNextStep);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToResumeScriptSession) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToResumeScriptSession_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToResumeScriptSession);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToResumeScriptSession);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToTransform) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToTransform_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToTransform);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToTransform);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptingUIResource) => Property (UnableToUpdateScriptSession) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptingUIResourceDesigner_Public_Class_UnableToUpdateScriptSession_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnableToUpdateScriptSession);
            var propertyInfo = this.GetPropertyInfo(PropertyUnableToUpdateScriptSession);

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