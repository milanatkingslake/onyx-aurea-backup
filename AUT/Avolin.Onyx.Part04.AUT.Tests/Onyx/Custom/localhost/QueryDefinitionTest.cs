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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.QueryDefinition" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class QueryDefinitionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="QueryDefinition" />)
        /// </summary>
        public QueryDefinitionTest() : base(typeof(QueryDefinition))
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

        #region General Initializer : Class (QueryDefinition) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _queryDefinitionInstanceType;
        private QueryDefinition _queryDefinitionInstance;
        private QueryDefinition _queryDefinitionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="QueryDefinition" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _queryDefinitionInstanceType = typeof(QueryDefinition);
            _queryDefinitionInstanceFixture = this.Create<QueryDefinition>(false);
            _queryDefinitionInstance = _queryDefinitionInstanceFixture ?? this.Create<QueryDefinition>(true);
            CurrentInstance = _queryDefinitionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (QueryDefinition) Initializer

        #region Properties

        private const string PropertyCommandType = "CommandType";
        private const string PropertyCommandText = "CommandText";
        private const string PropertyTimeout = "Timeout";
        private const string PropertyTimeoutSpecified = "TimeoutSpecified";

        #endregion

        #region Fields

        private const string FieldcommandTypeField = "commandTypeField";
        private const string FieldcommandTextField = "commandTextField";
        private const string FieldtimeoutField = "timeoutField";
        private const string FieldtimeoutFieldSpecified = "timeoutFieldSpecified";

        #endregion

        #endregion

        #region General Initializer : Class (QueryDefinition) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="QueryDefinition" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_QueryDefinition_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (QueryDefinition) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="QueryDefinition" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_QueryDefinition_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (QueryDefinition) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="QueryDefinition" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_QueryDefinition_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (QueryDefinition)

        #region General Initializer : Class (QueryDefinition) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="QueryDefinition" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyCommandType)]
        [TestCase(PropertyCommandText)]
        [TestCase(PropertyTimeout)]
        [TestCase(PropertyTimeoutSpecified)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_QueryDefinition_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (QueryDefinition) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="QueryDefinition" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldcommandTypeField)]
        [TestCase(FieldcommandTextField)]
        [TestCase(FieldtimeoutField)]
        [TestCase(FieldtimeoutFieldSpecified)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_QueryDefinition_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (QueryDefinition) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="QueryDefinition" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_QueryDefinition_Is_Instance_Present_Test()
        {
            // Assert
            _queryDefinitionInstanceType.ShouldNotBeNull();
            _queryDefinitionInstance.ShouldNotBeNull();
            _queryDefinitionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (QueryDefinition) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="QueryDefinition" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_QueryDefinition_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _queryDefinitionInstance.ShouldBeAssignableTo<QueryDefinition>();
            _queryDefinitionInstanceFixture.ShouldBeAssignableTo<QueryDefinition>();
            CurrentInstance.ShouldBeAssignableTo<QueryDefinition>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (QueryDefinition) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_QueryDefinition_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            QueryDefinition instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (QueryDefinition) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyCommandType)]
        [TestCase(PropertyCommandText)]
        [TestCase(PropertyTimeout)]
        [TestCase(PropertyTimeoutSpecified)]
        public void AUT_QueryDefinition_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (QueryDefinition) => Property (CommandText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_QueryDefinition_Public_Class_CommandText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCommandText);
            var propertyInfo = this.GetPropertyInfo(PropertyCommandText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryDefinition) => Property (CommandType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_QueryDefinition_Public_Class_CommandType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCommandType);
            var propertyInfo = this.GetPropertyInfo(PropertyCommandType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryDefinition) => Property (Timeout) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_QueryDefinition_Public_Class_Timeout_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTimeout);
            var propertyInfo = this.GetPropertyInfo(PropertyTimeout);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryDefinition) => Property (TimeoutSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_QueryDefinition_Public_Class_TimeoutSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTimeoutSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyTimeoutSpecified);

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