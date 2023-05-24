using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Core.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Core.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Core.Model.MessageModel" />)
    ///     and namespace <see cref="Onyx.UI.Core.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MessageModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MessageModel" />)
        /// </summary>
        public MessageModelTest() : base(typeof(MessageModel))
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

        #region General Initializer : Class (MessageModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _messageModelInstanceType;
        private MessageModel _messageModelInstance;
        private MessageModel _messageModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="MessageModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _messageModelInstanceType = typeof(MessageModel);
            _messageModelInstanceFixture = this.Create<MessageModel>(false);
            _messageModelInstance = _messageModelInstanceFixture ?? this.Create<MessageModel>(true);
            CurrentInstance = _messageModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (MessageModel) Initializer

        #region Properties

        private const string PropertyNumber = "Number";
        private const string PropertyNatLangId = "NatLangId";
        private const string PropertyMessage = "Message";
        private const string PropertyType = "Type";
        private const string PropertyIsException = "IsException";
        private const string PropertyLanguage = "Language";

        #endregion

        #endregion

        #region General Initializer : Class (MessageModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MessageModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MessageModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MessageModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="MessageModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MessageModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MessageModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="MessageModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MessageModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MessageModel)

        #region General Initializer : Class (MessageModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="MessageModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNumber)]
        [TestCase(PropertyNatLangId)]
        [TestCase(PropertyMessage)]
        [TestCase(PropertyType)]
        [TestCase(PropertyIsException)]
        [TestCase(PropertyLanguage)]
        [Category("AUT Property")]
        public void AUT_MessageModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (MessageModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MessageModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MessageModel_Is_Instance_Present_Test()
        {
            // Assert
            _messageModelInstanceType.ShouldNotBeNull();
            _messageModelInstance.ShouldNotBeNull();
            _messageModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MessageModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MessageModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MessageModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _messageModelInstance.ShouldBeAssignableTo<MessageModel>();
            _messageModelInstanceFixture.ShouldBeAssignableTo<MessageModel>();
            CurrentInstance.ShouldBeAssignableTo<MessageModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MessageModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MessageModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            MessageModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (MessageModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyNumber)]
        [TestCase(PropertyNatLangId)]
        [TestCase(PropertyMessage)]
        [TestCase(PropertyType)]
        [TestCase(PropertyIsException)]
        [TestCase(PropertyLanguage)]
        public void AUT_MessageModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (MessageModel) => Property (IsException) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MessageModel_Public_Class_IsException_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsException);
            var propertyInfo = this.GetPropertyInfo(PropertyIsException);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MessageModel) => Property (Language) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MessageModel_Public_Class_Language_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLanguage);
            var propertyInfo = this.GetPropertyInfo(PropertyLanguage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MessageModel) => Property (Message) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MessageModel_Public_Class_Message_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (MessageModel) => Property (NatLangId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MessageModel_Public_Class_NatLangId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNatLangId);
            var propertyInfo = this.GetPropertyInfo(PropertyNatLangId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MessageModel) => Property (Number) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MessageModel_Public_Class_Number_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNumber);
            var propertyInfo = this.GetPropertyInfo(PropertyNumber);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MessageModel) => Property (Type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MessageModel_Public_Class_Type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyType);
            var propertyInfo = this.GetPropertyInfo(PropertyType);

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