using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom.localhost;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom.localhost
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.GetReportHistoryLimitCompletedEventArgs" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class GetReportHistoryLimitCompletedEventArgsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="GetReportHistoryLimitCompletedEventArgs" />)
        /// </summary>
        public GetReportHistoryLimitCompletedEventArgsTest() : base(typeof(GetReportHistoryLimitCompletedEventArgs))
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

        #region General Initializer : Class (GetReportHistoryLimitCompletedEventArgs) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _getReportHistoryLimitCompletedEventArgsInstanceType;
        private GetReportHistoryLimitCompletedEventArgs _getReportHistoryLimitCompletedEventArgsInstance;
        private GetReportHistoryLimitCompletedEventArgs _getReportHistoryLimitCompletedEventArgsInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="GetReportHistoryLimitCompletedEventArgs" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _getReportHistoryLimitCompletedEventArgsInstanceType = typeof(GetReportHistoryLimitCompletedEventArgs);
            _getReportHistoryLimitCompletedEventArgsInstanceFixture = this.Create<GetReportHistoryLimitCompletedEventArgs>(false);
            _getReportHistoryLimitCompletedEventArgsInstance = _getReportHistoryLimitCompletedEventArgsInstanceFixture ?? this.Create<GetReportHistoryLimitCompletedEventArgs>(true);
            CurrentInstance = _getReportHistoryLimitCompletedEventArgsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (GetReportHistoryLimitCompletedEventArgs) Initializer

        #region Properties

        private const string PropertyResult = "Result";
        private const string PropertyIsSystem = "IsSystem";
        private const string PropertySystemLimit = "SystemLimit";

        #endregion

        #region Fields

        private const string Fieldresults = "results";

        #endregion

        #endregion

        #region General Initializer : Class (GetReportHistoryLimitCompletedEventArgs) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="GetReportHistoryLimitCompletedEventArgs" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_GetReportHistoryLimitCompletedEventArgs_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GetReportHistoryLimitCompletedEventArgs) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="GetReportHistoryLimitCompletedEventArgs" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_GetReportHistoryLimitCompletedEventArgs_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GetReportHistoryLimitCompletedEventArgs) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="GetReportHistoryLimitCompletedEventArgs" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_GetReportHistoryLimitCompletedEventArgs_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (GetReportHistoryLimitCompletedEventArgs)

        #region General Initializer : Class (GetReportHistoryLimitCompletedEventArgs) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="GetReportHistoryLimitCompletedEventArgs" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyResult)]
        [TestCase(PropertyIsSystem)]
        [TestCase(PropertySystemLimit)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_GetReportHistoryLimitCompletedEventArgs_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (GetReportHistoryLimitCompletedEventArgs) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="GetReportHistoryLimitCompletedEventArgs" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(Fieldresults)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_GetReportHistoryLimitCompletedEventArgs_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (GetReportHistoryLimitCompletedEventArgs) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="GetReportHistoryLimitCompletedEventArgs" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_GetReportHistoryLimitCompletedEventArgs_Is_Instance_Present_Test()
        {
            // Assert
            _getReportHistoryLimitCompletedEventArgsInstanceType.ShouldNotBeNull();
            _getReportHistoryLimitCompletedEventArgsInstance.ShouldNotBeNull();
            _getReportHistoryLimitCompletedEventArgsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (GetReportHistoryLimitCompletedEventArgs) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="GetReportHistoryLimitCompletedEventArgs" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_GetReportHistoryLimitCompletedEventArgs_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _getReportHistoryLimitCompletedEventArgsInstance.ShouldBeAssignableTo<GetReportHistoryLimitCompletedEventArgs>();
            _getReportHistoryLimitCompletedEventArgsInstanceFixture.ShouldBeAssignableTo<GetReportHistoryLimitCompletedEventArgs>();
            CurrentInstance.ShouldBeAssignableTo<GetReportHistoryLimitCompletedEventArgs>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (GetReportHistoryLimitCompletedEventArgs) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyResult)]
        [TestCase(PropertyIsSystem)]
        [TestCase(PropertySystemLimit)]
        public void AUT_GetReportHistoryLimitCompletedEventArgs_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (GetReportHistoryLimitCompletedEventArgs) => Property (IsSystem) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetReportHistoryLimitCompletedEventArgs_Public_Class_IsSystem_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsSystem);
            var propertyInfo = this.GetPropertyInfo(PropertyIsSystem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GetReportHistoryLimitCompletedEventArgs) => Property (Result) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetReportHistoryLimitCompletedEventArgs_Public_Class_Result_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResult);
            var propertyInfo = this.GetPropertyInfo(PropertyResult);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GetReportHistoryLimitCompletedEventArgs) => Property (SystemLimit) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetReportHistoryLimitCompletedEventArgs_Public_Class_SystemLimit_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySystemLimit);
            var propertyInfo = this.GetPropertyInfo(PropertySystemLimit);

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