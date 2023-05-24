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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Survey.Model.SurveyOwnerQuestionResponse" />)
    ///     and namespace <see cref="Onyx.UI.Survey.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SurveyOwnerQuestionResponseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SurveyOwnerQuestionResponse" />)
        /// </summary>
        public SurveyOwnerQuestionResponseTest() : base(typeof(SurveyOwnerQuestionResponse))
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

        #region General Initializer : Class (SurveyOwnerQuestionResponse) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _surveyOwnerQuestionResponseInstanceType;
        private SurveyOwnerQuestionResponse _surveyOwnerQuestionResponseInstance;
        private SurveyOwnerQuestionResponse _surveyOwnerQuestionResponseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SurveyOwnerQuestionResponse" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _surveyOwnerQuestionResponseInstanceType = typeof(SurveyOwnerQuestionResponse);
            _surveyOwnerQuestionResponseInstanceFixture = this.Create<SurveyOwnerQuestionResponse>(false);
            _surveyOwnerQuestionResponseInstance = _surveyOwnerQuestionResponseInstanceFixture ?? this.Create<SurveyOwnerQuestionResponse>(true);
            CurrentInstance = _surveyOwnerQuestionResponseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SurveyOwnerQuestionResponse) Initializer

        #region Properties

        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertySurveyOwnerId = "SurveyOwnerId";
        private const string PropertySurveyOwnerType = "SurveyOwnerType";
        private const string PropertyQuestionId = "QuestionId";
        private const string PropertyQuestionType = "QuestionType";
        private const string PropertyResponseId = "ResponseId";
        private const string PropertyResponseText = "ResponseText";
        private const string PropertyResponseSequenceNumber = "ResponseSequenceNumber";
        private const string PropertyFreeText = "FreeText";
        private const string PropertyQuestionText = "QuestionText";
        private const string PropertyQuestionSequenceNumber = "QuestionSequenceNumber";

        #endregion

        #endregion

        #region General Initializer : Class (SurveyOwnerQuestionResponse) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SurveyOwnerQuestionResponse" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SurveyOwnerQuestionResponse_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SurveyOwnerQuestionResponse) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SurveyOwnerQuestionResponse" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SurveyOwnerQuestionResponse_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SurveyOwnerQuestionResponse) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SurveyOwnerQuestionResponse" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SurveyOwnerQuestionResponse_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SurveyOwnerQuestionResponse)

        #region General Initializer : Class (SurveyOwnerQuestionResponse) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SurveyOwnerQuestionResponse" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertySurveyOwnerId)]
        [TestCase(PropertySurveyOwnerType)]
        [TestCase(PropertyQuestionId)]
        [TestCase(PropertyQuestionType)]
        [TestCase(PropertyResponseId)]
        [TestCase(PropertyResponseText)]
        [TestCase(PropertyResponseSequenceNumber)]
        [TestCase(PropertyFreeText)]
        [TestCase(PropertyQuestionText)]
        [TestCase(PropertyQuestionSequenceNumber)]
        [Category("AUT Property")]
        public void AUT_SurveyOwnerQuestionResponse_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SurveyOwnerQuestionResponse) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SurveyOwnerQuestionResponse" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyOwnerQuestionResponse_Is_Instance_Present_Test()
        {
            // Assert
            _surveyOwnerQuestionResponseInstanceType.ShouldNotBeNull();
            _surveyOwnerQuestionResponseInstance.ShouldNotBeNull();
            _surveyOwnerQuestionResponseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SurveyOwnerQuestionResponse) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SurveyOwnerQuestionResponse" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyOwnerQuestionResponse_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _surveyOwnerQuestionResponseInstance.ShouldBeAssignableTo<SurveyOwnerQuestionResponse>();
            _surveyOwnerQuestionResponseInstanceFixture.ShouldBeAssignableTo<SurveyOwnerQuestionResponse>();
            CurrentInstance.ShouldBeAssignableTo<SurveyOwnerQuestionResponse>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SurveyOwnerQuestionResponse) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SurveyOwnerQuestionResponse_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SurveyOwnerQuestionResponse instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SurveyOwnerQuestionResponse) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertySurveyOwnerId)]
        [TestCase(PropertySurveyOwnerType)]
        [TestCase(PropertyQuestionId)]
        [TestCase(PropertyQuestionType)]
        [TestCase(PropertyResponseId)]
        [TestCase(PropertyResponseText)]
        [TestCase(PropertyResponseSequenceNumber)]
        [TestCase(PropertyFreeText)]
        [TestCase(PropertyQuestionText)]
        [TestCase(PropertyQuestionSequenceNumber)]
        public void AUT_SurveyOwnerQuestionResponse_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SurveyOwnerQuestionResponse) => Property (FreeText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerQuestionResponse_Public_Class_FreeText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFreeText);
            var propertyInfo = this.GetPropertyInfo(PropertyFreeText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerQuestionResponse) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerQuestionResponse_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerQuestionResponse) => Property (QuestionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerQuestionResponse_Public_Class_QuestionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQuestionId);
            var propertyInfo = this.GetPropertyInfo(PropertyQuestionId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerQuestionResponse) => Property (QuestionSequenceNumber) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerQuestionResponse_Public_Class_QuestionSequenceNumber_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQuestionSequenceNumber);
            var propertyInfo = this.GetPropertyInfo(PropertyQuestionSequenceNumber);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerQuestionResponse) => Property (QuestionText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerQuestionResponse_Public_Class_QuestionText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQuestionText);
            var propertyInfo = this.GetPropertyInfo(PropertyQuestionText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerQuestionResponse) => Property (QuestionType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerQuestionResponse_Public_Class_QuestionType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQuestionType);
            var propertyInfo = this.GetPropertyInfo(PropertyQuestionType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerQuestionResponse) => Property (ResponseId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerQuestionResponse_Public_Class_ResponseId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResponseId);
            var propertyInfo = this.GetPropertyInfo(PropertyResponseId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerQuestionResponse) => Property (ResponseSequenceNumber) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerQuestionResponse_Public_Class_ResponseSequenceNumber_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResponseSequenceNumber);
            var propertyInfo = this.GetPropertyInfo(PropertyResponseSequenceNumber);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerQuestionResponse) => Property (ResponseText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerQuestionResponse_Public_Class_ResponseText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResponseText);
            var propertyInfo = this.GetPropertyInfo(PropertyResponseText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerQuestionResponse) => Property (SurveyOwnerId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerQuestionResponse_Public_Class_SurveyOwnerId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySurveyOwnerId);
            var propertyInfo = this.GetPropertyInfo(PropertySurveyOwnerId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerQuestionResponse) => Property (SurveyOwnerType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerQuestionResponse_Public_Class_SurveyOwnerType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySurveyOwnerType);
            var propertyInfo = this.GetPropertyInfo(PropertySurveyOwnerType);

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