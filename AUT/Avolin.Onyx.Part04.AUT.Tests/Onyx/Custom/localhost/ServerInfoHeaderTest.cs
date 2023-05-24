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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ServerInfoHeader" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ServerInfoHeaderTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ServerInfoHeader" />)
        /// </summary>
        public ServerInfoHeaderTest() : base(typeof(ServerInfoHeader))
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

        #region General Initializer : Class (ServerInfoHeader) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _serverInfoHeaderInstanceType;
        private ServerInfoHeader _serverInfoHeaderInstance;
        private ServerInfoHeader _serverInfoHeaderInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ServerInfoHeader" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _serverInfoHeaderInstanceType = typeof(ServerInfoHeader);
            _serverInfoHeaderInstanceFixture = this.Create<ServerInfoHeader>(false);
            _serverInfoHeaderInstance = _serverInfoHeaderInstanceFixture ?? this.Create<ServerInfoHeader>(true);
            CurrentInstance = _serverInfoHeaderInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ServerInfoHeader) Initializer

        #region Properties

        private const string PropertyReportServerVersionNumber = "ReportServerVersionNumber";
        private const string PropertyReportServerEdition = "ReportServerEdition";
        private const string PropertyReportServerVersion = "ReportServerVersion";
        private const string PropertyReportServerDateTime = "ReportServerDateTime";
        private const string PropertyAnyAttr = "AnyAttr";

        #endregion

        #region Fields

        private const string FieldreportServerVersionNumberField = "reportServerVersionNumberField";
        private const string FieldreportServerEditionField = "reportServerEditionField";
        private const string FieldreportServerVersionField = "reportServerVersionField";
        private const string FieldreportServerDateTimeField = "reportServerDateTimeField";
        private const string FieldanyAttrField = "anyAttrField";

        #endregion

        #endregion

        #region General Initializer : Class (ServerInfoHeader) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ServerInfoHeader" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ServerInfoHeader_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ServerInfoHeader) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ServerInfoHeader" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ServerInfoHeader_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ServerInfoHeader) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ServerInfoHeader" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ServerInfoHeader_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ServerInfoHeader)

        #region General Initializer : Class (ServerInfoHeader) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ServerInfoHeader" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyReportServerVersionNumber)]
        [TestCase(PropertyReportServerEdition)]
        [TestCase(PropertyReportServerVersion)]
        [TestCase(PropertyReportServerDateTime)]
        [TestCase(PropertyAnyAttr)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_ServerInfoHeader_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ServerInfoHeader) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ServerInfoHeader" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldreportServerVersionNumberField)]
        [TestCase(FieldreportServerEditionField)]
        [TestCase(FieldreportServerVersionField)]
        [TestCase(FieldreportServerDateTimeField)]
        [TestCase(FieldanyAttrField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_ServerInfoHeader_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ServerInfoHeader) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ServerInfoHeader" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ServerInfoHeader_Is_Instance_Present_Test()
        {
            // Assert
            _serverInfoHeaderInstanceType.ShouldNotBeNull();
            _serverInfoHeaderInstance.ShouldNotBeNull();
            _serverInfoHeaderInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ServerInfoHeader) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ServerInfoHeader" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ServerInfoHeader_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _serverInfoHeaderInstance.ShouldBeAssignableTo<ServerInfoHeader>();
            _serverInfoHeaderInstanceFixture.ShouldBeAssignableTo<ServerInfoHeader>();
            CurrentInstance.ShouldBeAssignableTo<ServerInfoHeader>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ServerInfoHeader) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ServerInfoHeader_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ServerInfoHeader instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ServerInfoHeader) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyReportServerVersionNumber)]
        [TestCase(PropertyReportServerEdition)]
        [TestCase(PropertyReportServerVersion)]
        [TestCase(PropertyReportServerDateTime)]
        [TestCase(PropertyAnyAttr)]
        public void AUT_ServerInfoHeader_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ServerInfoHeader) => Property (AnyAttr) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ServerInfoHeader_AnyAttr_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAnyAttr);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyAnyAttr);
            Action currentAction = () => propertyInfo.SetValue(_serverInfoHeaderInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ServerInfoHeader) => Property (AnyAttr) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ServerInfoHeader_Public_Class_AnyAttr_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAnyAttr);
            var propertyInfo = this.GetPropertyInfo(PropertyAnyAttr);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ServerInfoHeader) => Property (ReportServerDateTime) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ServerInfoHeader_Public_Class_ReportServerDateTime_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReportServerDateTime);
            var propertyInfo = this.GetPropertyInfo(PropertyReportServerDateTime);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ServerInfoHeader) => Property (ReportServerEdition) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ServerInfoHeader_Public_Class_ReportServerEdition_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReportServerEdition);
            var propertyInfo = this.GetPropertyInfo(PropertyReportServerEdition);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ServerInfoHeader) => Property (ReportServerVersion) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ServerInfoHeader_Public_Class_ReportServerVersion_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReportServerVersion);
            var propertyInfo = this.GetPropertyInfo(PropertyReportServerVersion);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ServerInfoHeader) => Property (ReportServerVersionNumber) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ServerInfoHeader_Public_Class_ReportServerVersionNumber_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReportServerVersionNumber);
            var propertyInfo = this.GetPropertyInfo(PropertyReportServerVersionNumber);

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