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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxDictionaryDAC.StepContextHelper" />)
    ///     and namespace <see cref="OnyxDictionaryDAC"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StepContextHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="StepContextHelperNonPublicTypeName" />) using
        ///     Using a public type <see cref="Dictionary" /> to
        ///     create a non-public type.
        /// </summary>
        public StepContextHelperTest() : base(publicType: typeof(Dictionary), classNameWithNamespace: StepContextHelperNonPublicTypeName)
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

        private Type _stepContextHelperInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string StepContextHelperNonPublicTypeName = "OnyxDictionaryDAC.StepContextHelper";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _stepContextHelperInstance;
        private object _stepContextHelperInstanceFixture;

        #region General Initializer : Class (StepContextHelper) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="StepContextHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _stepContextHelperInstanceFixture = this.CreateNonPublicType(StepContextHelperNonPublicTypeName);
            _stepContextHelperInstance = _stepContextHelperInstanceFixture;
            CurrentInstance = _stepContextHelperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StepContextHelper) Initializer

        #region Properties

        private const string PropertyUserID = "UserID";
        private const string PropertyPreferredLanguage = "PreferredLanguage";
        private const string PropertySiteID = "SiteID";
        private const string PropertyOTMID = "OTMID";
        private const string PropertyLogSettings = "LogSettings";
        private const string PropertyLogName = "LogName";
        private const string PropertyDOM = "DOM";
        private const string PropertyTopNode = "TopNode";
        private const string PropertyXML = "XML";

        #endregion

        #region Methods

        private const string MethodAttach = "Attach";
        private const string MethodDetach = "Detach";

        #endregion

        #region Fields

        private const string FieldmoDOMHelper = "moDOMHelper";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (StepContextHelper)

        #region General Initializer : Class (StepContextHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="StepContextHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAttach, 0)]
        [TestCase(MethodDetach, 0)]
        [Category("AUT Explore")]
        public void AUT_StepContextHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (StepContextHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="StepContextHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepContextHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (StepContextHelper) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="StepContextHelper" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyUserID)]
        [TestCase(PropertyPreferredLanguage)]
        [TestCase(PropertySiteID)]
        [TestCase(PropertyOTMID)]
        [TestCase(PropertyLogSettings)]
        [TestCase(PropertyLogName)]
        [TestCase(PropertyDOM)]
        [TestCase(PropertyTopNode)]
        [TestCase(PropertyXML)]
        [Category("AUT Property")]
        public void AUT_StepContextHelper_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (StepContextHelper) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="StepContextHelper" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepContextHelper_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (StepContextHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="StepContextHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldmoDOMHelper)]
        [Category("AUT Fields")]
        public void AUT_StepContextHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (StepContextHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="StepContextHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepContextHelper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (StepContextHelper) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyUserID)]
        [TestCase(PropertyPreferredLanguage)]
        [TestCase(PropertySiteID)]
        [TestCase(PropertyOTMID)]
        [TestCase(PropertyLogSettings)]
        [TestCase(PropertyLogName)]
        [TestCase(PropertyDOM)]
        [TestCase(PropertyTopNode)]
        [TestCase(PropertyXML)]
        public void AUT_StepContextHelper_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (StepContextHelper) => Property (LogName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepContextHelper_Public_Class_LogName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLogName);
            var propertyInfo = this.GetPropertyInfo(PropertyLogName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepContextHelper) => Property (LogSettings) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepContextHelper_Public_Class_LogSettings_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLogSettings);
            var propertyInfo = this.GetPropertyInfo(PropertyLogSettings);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepContextHelper) => Property (OTMID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepContextHelper_Public_Class_OTMID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOTMID);
            var propertyInfo = this.GetPropertyInfo(PropertyOTMID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepContextHelper) => Property (PreferredLanguage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepContextHelper_Public_Class_PreferredLanguage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPreferredLanguage);
            var propertyInfo = this.GetPropertyInfo(PropertyPreferredLanguage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepContextHelper) => Property (SiteID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepContextHelper_Public_Class_SiteID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySiteID);
            var propertyInfo = this.GetPropertyInfo(PropertySiteID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepContextHelper) => Property (TopNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepContextHelper_TopNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTopNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyTopNode);
            Action currentAction = () => propertyInfo.SetValue(_stepContextHelperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (StepContextHelper) => Property (TopNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepContextHelper_Public_Class_TopNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (StepContextHelper) => Property (UserID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepContextHelper_Public_Class_UserID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserID);
            var propertyInfo = this.GetPropertyInfo(PropertyUserID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepContextHelper) => Property (XML) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepContextHelper_Public_Class_XML_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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