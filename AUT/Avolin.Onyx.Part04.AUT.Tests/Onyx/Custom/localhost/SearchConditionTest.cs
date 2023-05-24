using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.SearchCondition" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class SearchConditionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SearchCondition" />)
        /// </summary>
        public SearchConditionTest() : base(typeof(SearchCondition))
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

        #region General Initializer : Class (SearchCondition) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _searchConditionInstanceType;
        private SearchCondition _searchConditionInstance;
        private SearchCondition _searchConditionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SearchCondition" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _searchConditionInstanceType = typeof(SearchCondition);
            _searchConditionInstanceFixture = this.Create<SearchCondition>(false);
            _searchConditionInstance = _searchConditionInstanceFixture ?? this.Create<SearchCondition>(true);
            CurrentInstance = _searchConditionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SearchCondition) Initializer

        #region Properties

        private const string PropertyCondition = "Condition";
        private const string PropertyConditionSpecified = "ConditionSpecified";

        #endregion

        #region Fields

        private const string FieldconditionField = "conditionField";
        private const string FieldconditionFieldSpecified = "conditionFieldSpecified";

        #endregion

        #endregion

        #region General Initializer : Class (SearchCondition) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SearchCondition" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_SearchCondition_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SearchCondition) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SearchCondition" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_SearchCondition_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SearchCondition) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SearchCondition" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_SearchCondition_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SearchCondition)

        #region General Initializer : Class (SearchCondition) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SearchCondition" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyCondition)]
        [TestCase(PropertyConditionSpecified)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_SearchCondition_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (SearchCondition) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SearchCondition" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldconditionField)]
        [TestCase(FieldconditionFieldSpecified)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_SearchCondition_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SearchCondition) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SearchCondition" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_SearchCondition_Is_Instance_Present_Test()
        {
            // Assert
            _searchConditionInstanceType.ShouldNotBeNull();
            _searchConditionInstance.ShouldNotBeNull();
            _searchConditionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SearchCondition) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SearchCondition" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_SearchCondition_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _searchConditionInstance.ShouldBeAssignableTo<SearchCondition>();
            _searchConditionInstanceFixture.ShouldBeAssignableTo<SearchCondition>();
            CurrentInstance.ShouldBeAssignableTo<SearchCondition>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SearchCondition) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_SearchCondition_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SearchCondition instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SearchCondition) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyCondition)]
        [TestCase(PropertyConditionSpecified)]
        public void AUT_SearchCondition_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SearchCondition) => Property (Condition) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_SearchCondition_Condition_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCondition);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCondition);
            Action currentAction = () => propertyInfo.SetValue(_searchConditionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SearchCondition) => Property (Condition) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_SearchCondition_Public_Class_Condition_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCondition);
            var propertyInfo = this.GetPropertyInfo(PropertyCondition);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SearchCondition) => Property (ConditionSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_SearchCondition_Public_Class_ConditionSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyConditionSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyConditionSpecified);

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