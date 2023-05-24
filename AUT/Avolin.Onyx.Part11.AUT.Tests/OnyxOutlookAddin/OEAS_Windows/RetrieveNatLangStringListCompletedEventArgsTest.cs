using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin.OEAS_Windows;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin.OEAS_Windows
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.OEAS_Windows.RetrieveNatLangStringListCompletedEventArgs" />)
    ///     and namespace <see cref="OnyxOutlookAddin.OEAS_Windows"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class RetrieveNatLangStringListCompletedEventArgsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RetrieveNatLangStringListCompletedEventArgs" />)
        /// </summary>
        public RetrieveNatLangStringListCompletedEventArgsTest() : base(typeof(RetrieveNatLangStringListCompletedEventArgs))
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

        #region General Initializer : Class (RetrieveNatLangStringListCompletedEventArgs) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _retrieveNatLangStringListCompletedEventArgsInstanceType;
        private RetrieveNatLangStringListCompletedEventArgs _retrieveNatLangStringListCompletedEventArgsInstance;
        private RetrieveNatLangStringListCompletedEventArgs _retrieveNatLangStringListCompletedEventArgsInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="RetrieveNatLangStringListCompletedEventArgs" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _retrieveNatLangStringListCompletedEventArgsInstanceType = typeof(RetrieveNatLangStringListCompletedEventArgs);
            _retrieveNatLangStringListCompletedEventArgsInstanceFixture = this.Create<RetrieveNatLangStringListCompletedEventArgs>(false);
            _retrieveNatLangStringListCompletedEventArgsInstance = _retrieveNatLangStringListCompletedEventArgsInstanceFixture ?? this.Create<RetrieveNatLangStringListCompletedEventArgs>(true);
            CurrentInstance = _retrieveNatLangStringListCompletedEventArgsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (RetrieveNatLangStringListCompletedEventArgs) Initializer

        #region Properties

        private const string PropertyResult = "Result";

        #endregion

        #region Fields

        private const string Fieldresults = "results";

        #endregion

        #endregion

        #region General Initializer : Class (RetrieveNatLangStringListCompletedEventArgs) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="RetrieveNatLangStringListCompletedEventArgs" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_RetrieveNatLangStringListCompletedEventArgs_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (RetrieveNatLangStringListCompletedEventArgs) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="RetrieveNatLangStringListCompletedEventArgs" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_RetrieveNatLangStringListCompletedEventArgs_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (RetrieveNatLangStringListCompletedEventArgs) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="RetrieveNatLangStringListCompletedEventArgs" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_RetrieveNatLangStringListCompletedEventArgs_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RetrieveNatLangStringListCompletedEventArgs)

        #region General Initializer : Class (RetrieveNatLangStringListCompletedEventArgs) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="RetrieveNatLangStringListCompletedEventArgs" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyResult)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_RetrieveNatLangStringListCompletedEventArgs_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (RetrieveNatLangStringListCompletedEventArgs) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="RetrieveNatLangStringListCompletedEventArgs" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(Fieldresults)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_RetrieveNatLangStringListCompletedEventArgs_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (RetrieveNatLangStringListCompletedEventArgs) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RetrieveNatLangStringListCompletedEventArgs" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_RetrieveNatLangStringListCompletedEventArgs_Is_Instance_Present_Test()
        {
            // Assert
            _retrieveNatLangStringListCompletedEventArgsInstanceType.ShouldNotBeNull();
            _retrieveNatLangStringListCompletedEventArgsInstance.ShouldNotBeNull();
            _retrieveNatLangStringListCompletedEventArgsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (RetrieveNatLangStringListCompletedEventArgs) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="RetrieveNatLangStringListCompletedEventArgs" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_RetrieveNatLangStringListCompletedEventArgs_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _retrieveNatLangStringListCompletedEventArgsInstance.ShouldBeAssignableTo<RetrieveNatLangStringListCompletedEventArgs>();
            _retrieveNatLangStringListCompletedEventArgsInstanceFixture.ShouldBeAssignableTo<RetrieveNatLangStringListCompletedEventArgs>();
            CurrentInstance.ShouldBeAssignableTo<RetrieveNatLangStringListCompletedEventArgs>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (RetrieveNatLangStringListCompletedEventArgs) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyResult)]
        public void AUT_RetrieveNatLangStringListCompletedEventArgs_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (RetrieveNatLangStringListCompletedEventArgs) => Property (Result) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_RetrieveNatLangStringListCompletedEventArgs_Result_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResult);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyResult);
            Action currentAction = () => propertyInfo.SetValue(_retrieveNatLangStringListCompletedEventArgsInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (RetrieveNatLangStringListCompletedEventArgs) => Property (Result) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_RetrieveNatLangStringListCompletedEventArgs_Public_Class_Result_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion

        #endregion
    }
}