using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.AuditManifest" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AuditManifestTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AuditManifest" />)
        /// </summary>
        public AuditManifestTest() : base(typeof(AuditManifest))
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

        #region General Initializer : Class (AuditManifest) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _auditManifestInstanceType;
        private AuditManifest _auditManifestInstance;
        private AuditManifest _auditManifestInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="AuditManifest" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _auditManifestInstanceType = typeof(AuditManifest);
            _auditManifestInstanceFixture = this.Create<AuditManifest>(false);
            _auditManifestInstance = _auditManifestInstanceFixture ?? this.Create<AuditManifest>(true);
            CurrentInstance = _auditManifestInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AuditManifest) Initializer

        #region Properties

        private const string PropertyAuditTrailId = "AuditTrailId";
        private const string PropertyMessage = "Message";
        private const string PropertySource = "Source";
        private const string PropertyStackTrace = "StackTrace";
        private const string PropertyLevel = "Level";

        #endregion

        #region Fields

        private const string FieldauditTrailId = "auditTrailId";

        #endregion

        #endregion

        #region General Initializer : Class (AuditManifest) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AuditManifest" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AuditManifest_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AuditManifest) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="AuditManifest" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AuditManifest_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AuditManifest) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AuditManifest" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AuditManifest_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AuditManifest)

        #region General Initializer : Class (AuditManifest) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="AuditManifest" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyAuditTrailId)]
        [TestCase(PropertyMessage)]
        [TestCase(PropertySource)]
        [TestCase(PropertyStackTrace)]
        [TestCase(PropertyLevel)]
        [Category("AUT Property")]
        public void AUT_AuditManifest_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (AuditManifest) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="AuditManifest" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldauditTrailId)]
        [Category("AUT Fields")]
        public void AUT_AuditManifest_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (AuditManifest) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="AuditManifest" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AuditManifest_Is_Instance_Present_Test()
        {
            // Assert
            _auditManifestInstanceType.ShouldNotBeNull();
            _auditManifestInstance.ShouldNotBeNull();
            _auditManifestInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (AuditManifest) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="AuditManifest" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AuditManifest_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _auditManifestInstance.ShouldBeAssignableTo<AuditManifest>();
            _auditManifestInstanceFixture.ShouldBeAssignableTo<AuditManifest>();
            CurrentInstance.ShouldBeAssignableTo<AuditManifest>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (AuditManifest) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_AuditManifest_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var exceptionMessage = this.CreateType<string>();
            var source = this.CreateType<string>();
            var stackTrace = this.CreateType<string>();
            var exceptionLevel = this.CreateType<string>();
            AuditManifest instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new AuditManifest(exceptionMessage, source, stackTrace, exceptionLevel);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _auditManifestInstance.ShouldNotBeNull();
            _auditManifestInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<AuditManifest>();
        }

        #endregion

        #region General Constructor : Class (AuditManifest) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_AuditManifest_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var exceptionMessage = this.CreateType<string>();
            var source = this.CreateType<string>();
            var stackTrace = this.CreateType<string>();
            var exceptionLevel = this.CreateType<string>();
            AuditManifest instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new AuditManifest(exceptionMessage, source, stackTrace, exceptionLevel);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _auditManifestInstance.ShouldNotBeNull();
            _auditManifestInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (AuditManifest) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyAuditTrailId)]
        [TestCase(PropertyMessage)]
        [TestCase(PropertySource)]
        [TestCase(PropertyStackTrace)]
        [TestCase(PropertyLevel)]
        public void AUT_AuditManifest_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (AuditManifest) => Property (AuditTrailId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AuditManifest_AuditTrailId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAuditTrailId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyAuditTrailId);
            Action currentAction = () => propertyInfo.SetValue(_auditManifestInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (AuditManifest) => Property (AuditTrailId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AuditManifest_Public_Class_AuditTrailId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAuditTrailId);
            var propertyInfo = this.GetPropertyInfo(PropertyAuditTrailId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (AuditManifest) => Property (Level) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AuditManifest_Public_Class_Level_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLevel);
            var propertyInfo = this.GetPropertyInfo(PropertyLevel);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (AuditManifest) => Property (Message) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AuditManifest_Public_Class_Message_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (AuditManifest) => Property (Source) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AuditManifest_Public_Class_Source_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySource);
            var propertyInfo = this.GetPropertyInfo(PropertySource);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (AuditManifest) => Property (StackTrace) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AuditManifest_Public_Class_StackTrace_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStackTrace);
            var propertyInfo = this.GetPropertyInfo(PropertyStackTrace);

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