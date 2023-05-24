using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.Onyx;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.Onyx
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.Onyx.StepPackageContext" />)
    ///     and namespace <see cref="ConsonaCRM.Onyx"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StepPackageContextTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="StepPackageContext" />)
        /// </summary>
        public StepPackageContextTest() : base(typeof(StepPackageContext))
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

        #region General Initializer : Class (StepPackageContext) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _stepPackageContextInstanceType;
        private StepPackageContext _stepPackageContextInstance;
        private StepPackageContext _stepPackageContextInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="StepPackageContext" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _stepPackageContextInstanceType = typeof(StepPackageContext);
            _stepPackageContextInstanceFixture = this.Create<StepPackageContext>(false);
            _stepPackageContextInstance = _stepPackageContextInstanceFixture ?? this.Create<StepPackageContext>(true);
            CurrentInstance = _stepPackageContextInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StepPackageContext) Initializer

        #region Properties

        private const string PropertysessionID = "sessionID";
        private const string PropertyuserID = "userID";
        private const string PropertypartnerUser = "partnerUser";
        private const string PropertysiteID = "siteID";
        private const string PropertyapplicationName = "applicationName";
        private const string Propertysource = "source";
        private const string PropertypreferredLanguage = "preferredLanguage";
        private const string PropertyoriginalUser = "originalUser";
        private const string PropertypermissionMask = "permissionMask";
        private const string PropertylogName = "logName";
        private const string PropertylogSettings = "logSettings";
        private const string PropertyimpersonatingUser = "impersonatingUser";
        private const string PropertysessionSecondsRemaining = "sessionSecondsRemaining";
        private const string PropertyotmID = "otmID";
        private const string PropertystepPackage = "stepPackage";

        #endregion

        #region Fields

        private const string Fieldm_stepPackage = "m_stepPackage";

        #endregion

        #endregion

        #region General Initializer : Class (StepPackageContext) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="StepPackageContext" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepPackageContext_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (StepPackageContext) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="StepPackageContext" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepPackageContext_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (StepPackageContext) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="StepPackageContext" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepPackageContext_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (StepPackageContext)

        #region General Initializer : Class (StepPackageContext) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="StepPackageContext" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertysessionID)]
        [TestCase(PropertyuserID)]
        [TestCase(PropertypartnerUser)]
        [TestCase(PropertysiteID)]
        [TestCase(PropertyapplicationName)]
        [TestCase(Propertysource)]
        [TestCase(PropertypreferredLanguage)]
        [TestCase(PropertyoriginalUser)]
        [TestCase(PropertypermissionMask)]
        [TestCase(PropertylogName)]
        [TestCase(PropertylogSettings)]
        [TestCase(PropertyimpersonatingUser)]
        [TestCase(PropertysessionSecondsRemaining)]
        [TestCase(PropertyotmID)]
        [TestCase(PropertystepPackage)]
        [Category("AUT Property")]
        public void AUT_StepPackageContext_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (StepPackageContext) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="StepPackageContext" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_stepPackage)]
        [Category("AUT Fields")]
        public void AUT_StepPackageContext_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (StepPackageContext) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="StepPackageContext" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StepPackageContext_Is_Instance_Present_Test()
        {
            // Assert
            _stepPackageContextInstanceType.ShouldNotBeNull();
            _stepPackageContextInstance.ShouldNotBeNull();
            _stepPackageContextInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (StepPackageContext) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="StepPackageContext" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StepPackageContext_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _stepPackageContextInstance.ShouldBeAssignableTo<StepPackageContext>();
            _stepPackageContextInstanceFixture.ShouldBeAssignableTo<StepPackageContext>();
            CurrentInstance.ShouldBeAssignableTo<StepPackageContext>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (StepPackageContext) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepPackageContext_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var pStepPackage = this.CreateType<StepPackage>();
            StepPackageContext instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new StepPackageContext(pStepPackage);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _stepPackageContextInstance.ShouldNotBeNull();
            _stepPackageContextInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<StepPackageContext>();
        }

        #endregion

        #region General Constructor : Class (StepPackageContext) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepPackageContext_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var pStepPackage = this.CreateType<StepPackage>();
            StepPackageContext instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new StepPackageContext(pStepPackage);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _stepPackageContextInstance.ShouldNotBeNull();
            _stepPackageContextInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (StepPackageContext) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertysessionID)]
        [TestCase(PropertyuserID)]
        [TestCase(PropertypartnerUser)]
        [TestCase(PropertysiteID)]
        [TestCase(PropertyapplicationName)]
        [TestCase(Propertysource)]
        [TestCase(PropertypreferredLanguage)]
        [TestCase(PropertyoriginalUser)]
        [TestCase(PropertypermissionMask)]
        [TestCase(PropertylogName)]
        [TestCase(PropertylogSettings)]
        [TestCase(PropertyimpersonatingUser)]
        [TestCase(PropertysessionSecondsRemaining)]
        [TestCase(PropertyotmID)]
        [TestCase(PropertystepPackage)]
        public void AUT_StepPackageContext_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (StepPackageContext) => Property (applicationName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_Public_Class_applicationName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyapplicationName);
            var propertyInfo = this.GetPropertyInfo(PropertyapplicationName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackageContext) => Property (impersonatingUser) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_Public_Class_impersonatingUser_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyimpersonatingUser);
            var propertyInfo = this.GetPropertyInfo(PropertyimpersonatingUser);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackageContext) => Property (logName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_Public_Class_logName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertylogName);
            var propertyInfo = this.GetPropertyInfo(PropertylogName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackageContext) => Property (logSettings) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_Public_Class_logSettings_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertylogSettings);
            var propertyInfo = this.GetPropertyInfo(PropertylogSettings);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackageContext) => Property (originalUser) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_Public_Class_originalUser_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyoriginalUser);
            var propertyInfo = this.GetPropertyInfo(PropertyoriginalUser);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackageContext) => Property (otmID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_Public_Class_otmID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyotmID);
            var propertyInfo = this.GetPropertyInfo(PropertyotmID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackageContext) => Property (partnerUser) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_Public_Class_partnerUser_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertypartnerUser);
            var propertyInfo = this.GetPropertyInfo(PropertypartnerUser);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackageContext) => Property (permissionMask) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_Public_Class_permissionMask_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertypermissionMask);
            var propertyInfo = this.GetPropertyInfo(PropertypermissionMask);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackageContext) => Property (preferredLanguage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_Public_Class_preferredLanguage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertypreferredLanguage);
            var propertyInfo = this.GetPropertyInfo(PropertypreferredLanguage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackageContext) => Property (sessionID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_Public_Class_sessionID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertysessionID);
            var propertyInfo = this.GetPropertyInfo(PropertysessionID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackageContext) => Property (sessionSecondsRemaining) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_Public_Class_sessionSecondsRemaining_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertysessionSecondsRemaining);
            var propertyInfo = this.GetPropertyInfo(PropertysessionSecondsRemaining);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackageContext) => Property (siteID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_Public_Class_siteID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertysiteID);
            var propertyInfo = this.GetPropertyInfo(PropertysiteID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackageContext) => Property (source) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_Public_Class_source_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertysource);
            var propertyInfo = this.GetPropertyInfo(Propertysource);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackageContext) => Property (stepPackage) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_stepPackage_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertystepPackage);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertystepPackage);
            Action currentAction = () => propertyInfo.SetValue(_stepPackageContextInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (StepPackageContext) => Property (stepPackage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_Public_Class_stepPackage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertystepPackage);
            var propertyInfo = this.GetPropertyInfo(PropertystepPackage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepPackageContext) => Property (userID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepPackageContext_Public_Class_userID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyuserID);
            var propertyInfo = this.GetPropertyInfo(PropertyuserID);

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