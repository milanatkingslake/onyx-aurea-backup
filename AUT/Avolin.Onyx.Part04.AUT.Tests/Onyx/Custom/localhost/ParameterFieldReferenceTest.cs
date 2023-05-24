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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ParameterFieldReference" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ParameterFieldReferenceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ParameterFieldReference" />)
        /// </summary>
        public ParameterFieldReferenceTest() : base(typeof(ParameterFieldReference))
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

        #region General Initializer : Class (ParameterFieldReference) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _parameterFieldReferenceInstanceType;
        private ParameterFieldReference _parameterFieldReferenceInstance;
        private ParameterFieldReference _parameterFieldReferenceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ParameterFieldReference" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _parameterFieldReferenceInstanceType = typeof(ParameterFieldReference);
            _parameterFieldReferenceInstanceFixture = this.Create<ParameterFieldReference>(false);
            _parameterFieldReferenceInstance = _parameterFieldReferenceInstanceFixture ?? this.Create<ParameterFieldReference>(true);
            CurrentInstance = _parameterFieldReferenceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ParameterFieldReference) Initializer

        #region Properties

        private const string PropertyParameterName = "ParameterName";
        private const string PropertyFieldAlias = "FieldAlias";

        #endregion

        #region Fields

        private const string FieldparameterNameField = "parameterNameField";
        private const string FieldfieldAliasField = "fieldAliasField";

        #endregion

        #endregion

        #region General Initializer : Class (ParameterFieldReference) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ParameterFieldReference" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ParameterFieldReference_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ParameterFieldReference) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ParameterFieldReference" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ParameterFieldReference_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ParameterFieldReference) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ParameterFieldReference" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ParameterFieldReference_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ParameterFieldReference)

        #region General Initializer : Class (ParameterFieldReference) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ParameterFieldReference" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyParameterName)]
        [TestCase(PropertyFieldAlias)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_ParameterFieldReference_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ParameterFieldReference) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ParameterFieldReference" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldparameterNameField)]
        [TestCase(FieldfieldAliasField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_ParameterFieldReference_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ParameterFieldReference) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ParameterFieldReference" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ParameterFieldReference_Is_Instance_Present_Test()
        {
            // Assert
            _parameterFieldReferenceInstanceType.ShouldNotBeNull();
            _parameterFieldReferenceInstance.ShouldNotBeNull();
            _parameterFieldReferenceInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ParameterFieldReference) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ParameterFieldReference" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ParameterFieldReference_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _parameterFieldReferenceInstance.ShouldBeAssignableTo<ParameterFieldReference>();
            _parameterFieldReferenceInstanceFixture.ShouldBeAssignableTo<ParameterFieldReference>();
            CurrentInstance.ShouldBeAssignableTo<ParameterFieldReference>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ParameterFieldReference) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ParameterFieldReference_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ParameterFieldReference instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ParameterFieldReference) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyParameterName)]
        [TestCase(PropertyFieldAlias)]
        public void AUT_ParameterFieldReference_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ParameterFieldReference) => Property (FieldAlias) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ParameterFieldReference_Public_Class_FieldAlias_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFieldAlias);
            var propertyInfo = this.GetPropertyInfo(PropertyFieldAlias);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ParameterFieldReference) => Property (ParameterName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ParameterFieldReference_Public_Class_ParameterName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParameterName);
            var propertyInfo = this.GetPropertyInfo(PropertyParameterName);

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