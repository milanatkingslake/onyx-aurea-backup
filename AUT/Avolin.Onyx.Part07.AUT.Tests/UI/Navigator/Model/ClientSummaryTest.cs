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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.ClientSummary" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ClientSummaryTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ClientSummary" />)
        /// </summary>
        public ClientSummaryTest() : base(typeof(ClientSummary))
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

        #region General Initializer : Class (ClientSummary) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _clientSummaryInstanceType;
        private ClientSummary _clientSummaryInstance;
        private ClientSummary _clientSummaryInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ClientSummary" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _clientSummaryInstanceType = typeof(ClientSummary);
            _clientSummaryInstanceFixture = this.Create<ClientSummary>(false);
            _clientSummaryInstance = _clientSummaryInstanceFixture ?? this.Create<ClientSummary>(true);
            CurrentInstance = _clientSummaryInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ClientSummary) Initializer

        #region Properties

        private const string PropertyEntityObject = "EntityObject";

        #endregion

        #region Fields

        private const string FieldGroups = "Groups";

        #endregion

        #endregion

        #region General Initializer : Class (ClientSummary) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ClientSummary" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ClientSummary_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ClientSummary) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ClientSummary" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ClientSummary_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ClientSummary) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ClientSummary" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ClientSummary_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ClientSummary)

        #region General Initializer : Class (ClientSummary) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ClientSummary" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyEntityObject)]
        [Category("AUT Property")]
        public void AUT_ClientSummary_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ClientSummary) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ClientSummary" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldGroups)]
        [Category("AUT Fields")]
        public void AUT_ClientSummary_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ClientSummary) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ClientSummary" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ClientSummary_Is_Instance_Present_Test()
        {
            // Assert
            _clientSummaryInstanceType.ShouldNotBeNull();
            _clientSummaryInstance.ShouldNotBeNull();
            _clientSummaryInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ClientSummary) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ClientSummary" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ClientSummary_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _clientSummaryInstance.ShouldBeAssignableTo<ClientSummary>();
            _clientSummaryInstanceFixture.ShouldBeAssignableTo<ClientSummary>();
            CurrentInstance.ShouldBeAssignableTo<ClientSummary>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ClientSummary) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ClientSummary_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ClientSummary instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ClientSummary) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyEntityObject)]
        public void AUT_ClientSummary_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ClientSummary) => Property (EntityObject) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ClientSummary_Public_Class_EntityObject_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEntityObject);
            var propertyInfo = this.GetPropertyInfo(PropertyEntityObject);

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