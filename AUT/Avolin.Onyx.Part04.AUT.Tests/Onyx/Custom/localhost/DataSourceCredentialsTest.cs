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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.DataSourceCredentials" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DataSourceCredentialsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DataSourceCredentials" />)
        /// </summary>
        public DataSourceCredentialsTest() : base(typeof(DataSourceCredentials))
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

        #region General Initializer : Class (DataSourceCredentials) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _dataSourceCredentialsInstanceType;
        private DataSourceCredentials _dataSourceCredentialsInstance;
        private DataSourceCredentials _dataSourceCredentialsInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DataSourceCredentials" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dataSourceCredentialsInstanceType = typeof(DataSourceCredentials);
            _dataSourceCredentialsInstanceFixture = this.Create<DataSourceCredentials>(false);
            _dataSourceCredentialsInstance = _dataSourceCredentialsInstanceFixture ?? this.Create<DataSourceCredentials>(true);
            CurrentInstance = _dataSourceCredentialsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DataSourceCredentials) Initializer

        #region Properties

        private const string PropertyDataSourceName = "DataSourceName";
        private const string PropertyUserName = "UserName";
        private const string PropertyPassword = "Password";

        #endregion

        #region Fields

        private const string FielddataSourceNameField = "dataSourceNameField";
        private const string FielduserNameField = "userNameField";
        private const string FieldpasswordField = "passwordField";

        #endregion

        #endregion

        #region General Initializer : Class (DataSourceCredentials) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DataSourceCredentials" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_DataSourceCredentials_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DataSourceCredentials) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="DataSourceCredentials" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_DataSourceCredentials_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DataSourceCredentials) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DataSourceCredentials" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_DataSourceCredentials_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DataSourceCredentials)

        #region General Initializer : Class (DataSourceCredentials) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="DataSourceCredentials" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyDataSourceName)]
        [TestCase(PropertyUserName)]
        [TestCase(PropertyPassword)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_DataSourceCredentials_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (DataSourceCredentials) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DataSourceCredentials" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FielddataSourceNameField)]
        [TestCase(FielduserNameField)]
        [TestCase(FieldpasswordField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_DataSourceCredentials_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DataSourceCredentials) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DataSourceCredentials" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_DataSourceCredentials_Is_Instance_Present_Test()
        {
            // Assert
            _dataSourceCredentialsInstanceType.ShouldNotBeNull();
            _dataSourceCredentialsInstance.ShouldNotBeNull();
            _dataSourceCredentialsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DataSourceCredentials) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DataSourceCredentials" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_DataSourceCredentials_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _dataSourceCredentialsInstance.ShouldBeAssignableTo<DataSourceCredentials>();
            _dataSourceCredentialsInstanceFixture.ShouldBeAssignableTo<DataSourceCredentials>();
            CurrentInstance.ShouldBeAssignableTo<DataSourceCredentials>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DataSourceCredentials) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_DataSourceCredentials_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DataSourceCredentials instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (DataSourceCredentials) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyDataSourceName)]
        [TestCase(PropertyUserName)]
        [TestCase(PropertyPassword)]
        public void AUT_DataSourceCredentials_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (DataSourceCredentials) => Property (DataSourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSourceCredentials_Public_Class_DataSourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDataSourceName);
            var propertyInfo = this.GetPropertyInfo(PropertyDataSourceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DataSourceCredentials) => Property (Password) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSourceCredentials_Public_Class_Password_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPassword);
            var propertyInfo = this.GetPropertyInfo(PropertyPassword);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DataSourceCredentials) => Property (UserName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSourceCredentials_Public_Class_UserName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserName);
            var propertyInfo = this.GetPropertyInfo(PropertyUserName);

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