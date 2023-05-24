using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.OnyxException;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.OnyxException
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OnyxException.OnyxExecuteException" />)
    ///     and namespace <see cref="OnyxSDK.Public.OnyxException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxExecuteExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxExecuteException" />)
        /// </summary>
        public OnyxExecuteExceptionTest() : base(typeof(OnyxExecuteException))
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

        #region General Initializer : Class (OnyxExecuteException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxExecuteExceptionInstanceType;
        private OnyxExecuteException _onyxExecuteExceptionInstance;
        private OnyxExecuteException _onyxExecuteExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxExecuteException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxExecuteExceptionInstanceType = typeof(OnyxExecuteException);
            _onyxExecuteExceptionInstanceFixture = this.Create<OnyxExecuteException>(false);
            _onyxExecuteExceptionInstance = _onyxExecuteExceptionInstanceFixture ?? this.Create<OnyxExecuteException>(true);
            CurrentInstance = _onyxExecuteExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxExecuteException) Initializer

        #region Properties

        private const string PropertyStatusType = "StatusType";
        private const string PropertyError = "Error";
        private const string PropertyOtmId = "OtmId";
        private const string PropertyMethodCallName = "MethodCallName";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxExecuteException) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxExecuteException" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxExecuteException_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxExecuteException) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxExecuteException" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxExecuteException_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxExecuteException) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxExecuteException" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxExecuteException_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxExecuteException)

        #region General Initializer : Class (OnyxExecuteException) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxExecuteException" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyStatusType)]
        [TestCase(PropertyError)]
        [TestCase(PropertyOtmId)]
        [TestCase(PropertyMethodCallName)]
        [Category("AUT Property")]
        public void AUT_OnyxExecuteException_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxExecuteException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxExecuteException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxExecuteException_Is_Instance_Present_Test()
        {
            // Assert
            _onyxExecuteExceptionInstanceType.ShouldNotBeNull();
            _onyxExecuteExceptionInstance.ShouldNotBeNull();
            _onyxExecuteExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxExecuteException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxExecuteException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxExecuteException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxExecuteExceptionInstance.ShouldBeAssignableTo<OnyxExecuteException>();
            _onyxExecuteExceptionInstanceFixture.ShouldBeAssignableTo<OnyxExecuteException>();
            CurrentInstance.ShouldBeAssignableTo<OnyxExecuteException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxExecuteException) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxExecuteException_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxExecuteException instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxExecuteException) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyStatusType)]
        [TestCase(PropertyError)]
        [TestCase(PropertyOtmId)]
        [TestCase(PropertyMethodCallName)]
        public void AUT_OnyxExecuteException_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxExecuteException) => Property (Error) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxExecuteException_Public_Class_Error_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyError);
            var propertyInfo = this.GetPropertyInfo(PropertyError);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxExecuteException) => Property (MethodCallName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxExecuteException_Public_Class_MethodCallName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMethodCallName);
            var propertyInfo = this.GetPropertyInfo(PropertyMethodCallName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxExecuteException) => Property (OtmId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxExecuteException_Public_Class_OtmId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOtmId);
            var propertyInfo = this.GetPropertyInfo(PropertyOtmId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxExecuteException) => Property (StatusType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxExecuteException_Public_Class_StatusType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatusType);
            var propertyInfo = this.GetPropertyInfo(PropertyStatusType);

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