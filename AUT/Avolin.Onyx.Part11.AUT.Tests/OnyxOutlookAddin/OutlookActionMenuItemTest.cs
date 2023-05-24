using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.OutlookActionMenuItem" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OutlookActionMenuItemTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OutlookActionMenuItem" />)
        /// </summary>
        public OutlookActionMenuItemTest() : base(typeof(OutlookActionMenuItem))
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

        #region General Initializer : Class (OutlookActionMenuItem) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _outlookActionMenuItemInstanceType;
        private OutlookActionMenuItem _outlookActionMenuItemInstance;
        private OutlookActionMenuItem _outlookActionMenuItemInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OutlookActionMenuItem" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _outlookActionMenuItemInstanceType = typeof(OutlookActionMenuItem);
            _outlookActionMenuItemInstanceFixture = this.Create<OutlookActionMenuItem>(false);
            _outlookActionMenuItemInstance = _outlookActionMenuItemInstanceFixture ?? this.Create<OutlookActionMenuItem>(true);
            CurrentInstance = _outlookActionMenuItemInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OutlookActionMenuItem) Initializer

        #region Properties

        private const string PropertyName = "Name";
        private const string PropertyTitle = "Title";
        private const string PropertyIsEmailMenuItem = "IsEmailMenuItem";
        private const string PropertyIsAppointmentMenuItem = "IsAppointmentMenuItem";
        private const string PropertyIsContactMenuItem = "IsContactMenuItem";

        #endregion

        #region Fields

        private const string Fieldname = "name";
        private const string Fieldtitle = "title";
        private const string FieldisEmail = "isEmail";
        private const string FieldisAppointment = "isAppointment";
        private const string FieldisContact = "isContact";

        #endregion

        #endregion

        #region General Initializer : Class (OutlookActionMenuItem) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OutlookActionMenuItem" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookActionMenuItem_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OutlookActionMenuItem) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OutlookActionMenuItem" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookActionMenuItem_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OutlookActionMenuItem) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OutlookActionMenuItem" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookActionMenuItem_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OutlookActionMenuItem)

        #region General Initializer : Class (OutlookActionMenuItem) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OutlookActionMenuItem" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyName)]
        [TestCase(PropertyTitle)]
        [TestCase(PropertyIsEmailMenuItem)]
        [TestCase(PropertyIsAppointmentMenuItem)]
        [TestCase(PropertyIsContactMenuItem)]
        [Category("AUT Property")]
        public void AUT_OutlookActionMenuItem_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OutlookActionMenuItem) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OutlookActionMenuItem" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldname)]
        [TestCase(Fieldtitle)]
        [TestCase(FieldisEmail)]
        [TestCase(FieldisAppointment)]
        [TestCase(FieldisContact)]
        [Category("AUT Fields")]
        public void AUT_OutlookActionMenuItem_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OutlookActionMenuItem) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OutlookActionMenuItem" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OutlookActionMenuItem_Is_Instance_Present_Test()
        {
            // Assert
            _outlookActionMenuItemInstanceType.ShouldNotBeNull();
            _outlookActionMenuItemInstance.ShouldNotBeNull();
            _outlookActionMenuItemInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OutlookActionMenuItem) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OutlookActionMenuItem" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OutlookActionMenuItem_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _outlookActionMenuItemInstance.ShouldBeAssignableTo<OutlookActionMenuItem>();
            _outlookActionMenuItemInstanceFixture.ShouldBeAssignableTo<OutlookActionMenuItem>();
            CurrentInstance.ShouldBeAssignableTo<OutlookActionMenuItem>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OutlookActionMenuItem) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OutlookActionMenuItem_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var actionData = this.CreateType<XElement>();
            OutlookActionMenuItem instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OutlookActionMenuItem(actionData);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _outlookActionMenuItemInstance.ShouldNotBeNull();
            _outlookActionMenuItemInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OutlookActionMenuItem>();
        }

        #endregion

        #region General Constructor : Class (OutlookActionMenuItem) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OutlookActionMenuItem_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var actionData = this.CreateType<XElement>();
            OutlookActionMenuItem instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OutlookActionMenuItem(actionData);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _outlookActionMenuItemInstance.ShouldNotBeNull();
            _outlookActionMenuItemInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OutlookActionMenuItem) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyName)]
        [TestCase(PropertyTitle)]
        [TestCase(PropertyIsEmailMenuItem)]
        [TestCase(PropertyIsAppointmentMenuItem)]
        [TestCase(PropertyIsContactMenuItem)]
        public void AUT_OutlookActionMenuItem_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OutlookActionMenuItem) => Property (IsAppointmentMenuItem) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookActionMenuItem_Public_Class_IsAppointmentMenuItem_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsAppointmentMenuItem);
            var propertyInfo = this.GetPropertyInfo(PropertyIsAppointmentMenuItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookActionMenuItem) => Property (IsContactMenuItem) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookActionMenuItem_Public_Class_IsContactMenuItem_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsContactMenuItem);
            var propertyInfo = this.GetPropertyInfo(PropertyIsContactMenuItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookActionMenuItem) => Property (IsEmailMenuItem) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookActionMenuItem_Public_Class_IsEmailMenuItem_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsEmailMenuItem);
            var propertyInfo = this.GetPropertyInfo(PropertyIsEmailMenuItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookActionMenuItem) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookActionMenuItem_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyName);
            var propertyInfo = this.GetPropertyInfo(PropertyName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookActionMenuItem) => Property (Title) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookActionMenuItem_Public_Class_Title_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle);

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