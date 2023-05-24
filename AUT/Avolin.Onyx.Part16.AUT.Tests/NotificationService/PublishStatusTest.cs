using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService
{
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.PublishStatus" />)
    ///     and namespace <see cref="NotificationService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class PublishStatusTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="PublishStatus" />)
        /// </summary>
        public PublishStatusTest() : base(typeof(PublishStatus))
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

        #region General Initializer : Class (PublishStatus) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _publishStatusInstanceType;
        private PublishStatus _publishStatusInstance;
        private PublishStatus _publishStatusInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="PublishStatus" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _publishStatusInstanceType = typeof(PublishStatus);
            _publishStatusInstanceFixture = this.Create<PublishStatus>(false);
            _publishStatusInstance = _publishStatusInstanceFixture ?? this.Create<PublishStatus>(true);
            CurrentInstance = _publishStatusInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (PublishStatus) Initializer

        #region Properties

        private const string PropertyStatusCode = "StatusCode";
        private const string PropertyStatusMessage = "StatusMessage";

        #endregion

        #region Fields

        private const string FieldstatusCode = "statusCode";
        private const string FieldstatusMessage = "statusMessage";

        #endregion

        #endregion

        #region General Initializer : Class (PublishStatus) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="PublishStatus" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PublishStatus_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (PublishStatus) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="PublishStatus" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PublishStatus_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (PublishStatus) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="PublishStatus" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PublishStatus_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (PublishStatus)

        #region General Initializer : Class (PublishStatus) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="PublishStatus" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyStatusCode)]
        [TestCase(PropertyStatusMessage)]
        [Category("AUT Property")]
        public void AUT_PublishStatus_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (PublishStatus) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="PublishStatus" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldstatusCode)]
        [TestCase(FieldstatusMessage)]
        [Category("AUT Fields")]
        public void AUT_PublishStatus_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (PublishStatus) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="PublishStatus" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PublishStatus_Is_Instance_Present_Test()
        {
            // Assert
            _publishStatusInstanceType.ShouldNotBeNull();
            _publishStatusInstance.ShouldNotBeNull();
            _publishStatusInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (PublishStatus) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="PublishStatus" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PublishStatus_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _publishStatusInstance.ShouldBeAssignableTo<PublishStatus>();
            _publishStatusInstanceFixture.ShouldBeAssignableTo<PublishStatus>();
            CurrentInstance.ShouldBeAssignableTo<PublishStatus>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (PublishStatus) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PublishStatus_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            PublishStatus instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (PublishStatus) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyStatusCode)]
        [TestCase(PropertyStatusMessage)]
        public void AUT_PublishStatus_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (PublishStatus) => Property (StatusCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PublishStatus_Public_Class_StatusCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatusCode);
            var propertyInfo = this.GetPropertyInfo(PropertyStatusCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PublishStatus) => Property (StatusMessage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PublishStatus_Public_Class_StatusMessage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatusMessage);
            var propertyInfo = this.GetPropertyInfo(PropertyStatusMessage);

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