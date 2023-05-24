using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Survey.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Survey.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Survey.Model.SurveyMetadata" />)
    ///     and namespace <see cref="Onyx.UI.Survey.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SurveyMetadataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SurveyMetadata" />)
        /// </summary>
        public SurveyMetadataTest() : base(typeof(SurveyMetadata))
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

        #region General Initializer : Class (SurveyMetadata) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _surveyMetadataInstanceType;
        private SurveyMetadata _surveyMetadataInstance;
        private SurveyMetadata _surveyMetadataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SurveyMetadata" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _surveyMetadataInstanceType = typeof(SurveyMetadata);
            _surveyMetadataInstanceFixture = this.Create<SurveyMetadata>(false);
            _surveyMetadataInstance = _surveyMetadataInstanceFixture ?? this.Create<SurveyMetadata>(true);
            CurrentInstance = _surveyMetadataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SurveyMetadata) Initializer

        #region Properties

        private const string PropertySurveyId = "SurveyId";
        private const string PropertySurveyTypeId = "SurveyTypeId";
        private const string PropertySurveyTypeDescription = "SurveyTypeDescription";
        private const string PropertySurveyTypeActive = "SurveyTypeActive";
        private const string PropertyActive = "Active";
        private const string PropertySurveyName = "SurveyName";
        private const string PropertySurveyDescription = "SurveyDescription";
        private const string PropertyQuestionMetadata = "QuestionMetadata";

        #endregion

        #endregion

        #region General Initializer : Class (SurveyMetadata) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SurveyMetadata" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SurveyMetadata_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SurveyMetadata) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SurveyMetadata" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SurveyMetadata_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SurveyMetadata) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SurveyMetadata" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SurveyMetadata_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SurveyMetadata)

        #region General Initializer : Class (SurveyMetadata) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SurveyMetadata" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertySurveyId)]
        [TestCase(PropertySurveyTypeId)]
        [TestCase(PropertySurveyTypeDescription)]
        [TestCase(PropertySurveyTypeActive)]
        [TestCase(PropertyActive)]
        [TestCase(PropertySurveyName)]
        [TestCase(PropertySurveyDescription)]
        [TestCase(PropertyQuestionMetadata)]
        [Category("AUT Property")]
        public void AUT_SurveyMetadata_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (SurveyMetadata) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SurveyMetadata" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyMetadata_Is_Instance_Present_Test()
        {
            // Assert
            _surveyMetadataInstanceType.ShouldNotBeNull();
            _surveyMetadataInstance.ShouldNotBeNull();
            _surveyMetadataInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SurveyMetadata) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SurveyMetadata" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyMetadata_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _surveyMetadataInstance.ShouldBeAssignableTo<SurveyMetadata>();
            _surveyMetadataInstanceFixture.ShouldBeAssignableTo<SurveyMetadata>();
            CurrentInstance.ShouldBeAssignableTo<SurveyMetadata>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SurveyMetadata) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SurveyMetadata_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SurveyMetadata instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SurveyMetadata) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertySurveyId)]
        [TestCase(PropertySurveyTypeId)]
        [TestCase(PropertySurveyTypeDescription)]
        [TestCase(PropertySurveyTypeActive)]
        [TestCase(PropertyActive)]
        [TestCase(PropertySurveyName)]
        [TestCase(PropertySurveyDescription)]
        [TestCase(PropertyQuestionMetadata)]
        public void AUT_SurveyMetadata_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SurveyMetadata) => Property (Active) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyMetadata_Public_Class_Active_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActive);
            var propertyInfo = this.GetPropertyInfo(PropertyActive);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyMetadata) => Property (QuestionMetadata) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyMetadata_Public_Class_QuestionMetadata_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQuestionMetadata);
            var propertyInfo = this.GetPropertyInfo(PropertyQuestionMetadata);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyMetadata) => Property (SurveyDescription) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyMetadata_Public_Class_SurveyDescription_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySurveyDescription);
            var propertyInfo = this.GetPropertyInfo(PropertySurveyDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyMetadata) => Property (SurveyId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyMetadata_Public_Class_SurveyId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySurveyId);
            var propertyInfo = this.GetPropertyInfo(PropertySurveyId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyMetadata) => Property (SurveyName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyMetadata_Public_Class_SurveyName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySurveyName);
            var propertyInfo = this.GetPropertyInfo(PropertySurveyName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyMetadata) => Property (SurveyTypeActive) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyMetadata_Public_Class_SurveyTypeActive_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySurveyTypeActive);
            var propertyInfo = this.GetPropertyInfo(PropertySurveyTypeActive);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyMetadata) => Property (SurveyTypeDescription) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyMetadata_Public_Class_SurveyTypeDescription_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySurveyTypeDescription);
            var propertyInfo = this.GetPropertyInfo(PropertySurveyTypeDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyMetadata) => Property (SurveyTypeId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyMetadata_Public_Class_SurveyTypeId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySurveyTypeId);
            var propertyInfo = this.GetPropertyInfo(PropertySurveyTypeId);

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