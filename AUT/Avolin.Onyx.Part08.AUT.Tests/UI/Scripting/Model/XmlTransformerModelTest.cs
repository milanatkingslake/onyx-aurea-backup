using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Model.XmlTransformerModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class XmlTransformerModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="XmlTransformerModel" />)
        /// </summary>
        public XmlTransformerModelTest() : base(typeof(XmlTransformerModel))
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

        #region General Initializer : Class (XmlTransformerModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _xmlTransformerModelInstanceType;
        private XmlTransformerModel _xmlTransformerModelInstance;
        private XmlTransformerModel _xmlTransformerModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="XmlTransformerModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _xmlTransformerModelInstanceType = typeof(XmlTransformerModel);
            _xmlTransformerModelInstanceFixture = this.Create<XmlTransformerModel>(false);
            _xmlTransformerModelInstance = _xmlTransformerModelInstanceFixture ?? this.Create<XmlTransformerModel>(true);
            CurrentInstance = _xmlTransformerModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (XmlTransformerModel) Initializer

        #region Properties

        private const string PropertyXslName = "XslName";
        private const string PropertyXmlData = "XmlData";

        #endregion

        #endregion

        #region General Initializer : Class (XmlTransformerModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="XmlTransformerModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlTransformerModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (XmlTransformerModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="XmlTransformerModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlTransformerModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (XmlTransformerModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="XmlTransformerModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlTransformerModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (XmlTransformerModel)

        #region General Initializer : Class (XmlTransformerModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="XmlTransformerModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyXslName)]
        [TestCase(PropertyXmlData)]
        [Category("AUT Property")]
        public void AUT_XmlTransformerModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (XmlTransformerModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="XmlTransformerModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlTransformerModel_Is_Instance_Present_Test()
        {
            // Assert
            _xmlTransformerModelInstanceType.ShouldNotBeNull();
            _xmlTransformerModelInstance.ShouldNotBeNull();
            _xmlTransformerModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (XmlTransformerModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="XmlTransformerModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlTransformerModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _xmlTransformerModelInstance.ShouldBeAssignableTo<XmlTransformerModel>();
            _xmlTransformerModelInstanceFixture.ShouldBeAssignableTo<XmlTransformerModel>();
            CurrentInstance.ShouldBeAssignableTo<XmlTransformerModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (XmlTransformerModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_XmlTransformerModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            XmlTransformerModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (XmlTransformerModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyXslName)]
        [TestCase(PropertyXmlData)]
        public void AUT_XmlTransformerModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (XmlTransformerModel) => Property (XmlData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_XmlTransformerModel_Public_Class_XmlData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyXmlData);
            var propertyInfo = this.GetPropertyInfo(PropertyXmlData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (XmlTransformerModel) => Property (XslName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_XmlTransformerModel_Public_Class_XslName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyXslName);
            var propertyInfo = this.GetPropertyInfo(PropertyXslName);

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