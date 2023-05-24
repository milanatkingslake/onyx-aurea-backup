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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.GetItemTypeCompletedEventArgs" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class GetItemTypeCompletedEventArgsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="GetItemTypeCompletedEventArgs" />)
        /// </summary>
        public GetItemTypeCompletedEventArgsTest() : base(typeof(GetItemTypeCompletedEventArgs))
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

        #region General Initializer : Class (GetItemTypeCompletedEventArgs) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _getItemTypeCompletedEventArgsInstanceType;
        private GetItemTypeCompletedEventArgs _getItemTypeCompletedEventArgsInstance;
        private GetItemTypeCompletedEventArgs _getItemTypeCompletedEventArgsInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="GetItemTypeCompletedEventArgs" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _getItemTypeCompletedEventArgsInstanceType = typeof(GetItemTypeCompletedEventArgs);
            _getItemTypeCompletedEventArgsInstanceFixture = this.Create<GetItemTypeCompletedEventArgs>(false);
            _getItemTypeCompletedEventArgsInstance = _getItemTypeCompletedEventArgsInstanceFixture ?? this.Create<GetItemTypeCompletedEventArgs>(true);
            CurrentInstance = _getItemTypeCompletedEventArgsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (GetItemTypeCompletedEventArgs) Initializer

        #region Properties

        private const string PropertyResult = "Result";

        #endregion

        #region Fields

        private const string Fieldresults = "results";

        #endregion

        #endregion

        #region General Initializer : Class (GetItemTypeCompletedEventArgs) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="GetItemTypeCompletedEventArgs" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_GetItemTypeCompletedEventArgs_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GetItemTypeCompletedEventArgs) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="GetItemTypeCompletedEventArgs" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_GetItemTypeCompletedEventArgs_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GetItemTypeCompletedEventArgs) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="GetItemTypeCompletedEventArgs" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_GetItemTypeCompletedEventArgs_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (GetItemTypeCompletedEventArgs)

        #region General Initializer : Class (GetItemTypeCompletedEventArgs) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="GetItemTypeCompletedEventArgs" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyResult)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_GetItemTypeCompletedEventArgs_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (GetItemTypeCompletedEventArgs) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="GetItemTypeCompletedEventArgs" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(Fieldresults)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_GetItemTypeCompletedEventArgs_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (GetItemTypeCompletedEventArgs) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="GetItemTypeCompletedEventArgs" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_GetItemTypeCompletedEventArgs_Is_Instance_Present_Test()
        {
            // Assert
            _getItemTypeCompletedEventArgsInstanceType.ShouldNotBeNull();
            _getItemTypeCompletedEventArgsInstance.ShouldNotBeNull();
            _getItemTypeCompletedEventArgsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (GetItemTypeCompletedEventArgs) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="GetItemTypeCompletedEventArgs" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_GetItemTypeCompletedEventArgs_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _getItemTypeCompletedEventArgsInstance.ShouldBeAssignableTo<GetItemTypeCompletedEventArgs>();
            _getItemTypeCompletedEventArgsInstanceFixture.ShouldBeAssignableTo<GetItemTypeCompletedEventArgs>();
            CurrentInstance.ShouldBeAssignableTo<GetItemTypeCompletedEventArgs>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (GetItemTypeCompletedEventArgs) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyResult)]
        public void AUT_GetItemTypeCompletedEventArgs_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (GetItemTypeCompletedEventArgs) => Property (Result) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetItemTypeCompletedEventArgs_Result_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResult);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyResult);
            Action currentAction = () => propertyInfo.SetValue(_getItemTypeCompletedEventArgsInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (GetItemTypeCompletedEventArgs) => Property (Result) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetItemTypeCompletedEventArgs_Public_Class_Result_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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