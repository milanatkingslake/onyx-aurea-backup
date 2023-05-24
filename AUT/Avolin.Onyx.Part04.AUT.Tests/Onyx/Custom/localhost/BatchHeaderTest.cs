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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.BatchHeader" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class BatchHeaderTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="BatchHeader" />)
        /// </summary>
        public BatchHeaderTest() : base(typeof(BatchHeader))
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

        #region General Initializer : Class (BatchHeader) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _batchHeaderInstanceType;
        private BatchHeader _batchHeaderInstance;
        private BatchHeader _batchHeaderInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="BatchHeader" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _batchHeaderInstanceType = typeof(BatchHeader);
            _batchHeaderInstanceFixture = this.Create<BatchHeader>(false);
            _batchHeaderInstance = _batchHeaderInstanceFixture ?? this.Create<BatchHeader>(true);
            CurrentInstance = _batchHeaderInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (BatchHeader) Initializer

        #region Properties

        private const string PropertyBatchID = "BatchID";
        private const string PropertyAnyAttr = "AnyAttr";

        #endregion

        #region Fields

        private const string FieldbatchIDField = "batchIDField";
        private const string FieldanyAttrField = "anyAttrField";

        #endregion

        #endregion

        #region General Initializer : Class (BatchHeader) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="BatchHeader" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_BatchHeader_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (BatchHeader) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="BatchHeader" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_BatchHeader_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (BatchHeader) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="BatchHeader" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_BatchHeader_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (BatchHeader)

        #region General Initializer : Class (BatchHeader) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="BatchHeader" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyBatchID)]
        [TestCase(PropertyAnyAttr)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_BatchHeader_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (BatchHeader) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="BatchHeader" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldbatchIDField)]
        [TestCase(FieldanyAttrField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_BatchHeader_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (BatchHeader) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="BatchHeader" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_BatchHeader_Is_Instance_Present_Test()
        {
            // Assert
            _batchHeaderInstanceType.ShouldNotBeNull();
            _batchHeaderInstance.ShouldNotBeNull();
            _batchHeaderInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (BatchHeader) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="BatchHeader" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_BatchHeader_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _batchHeaderInstance.ShouldBeAssignableTo<BatchHeader>();
            _batchHeaderInstanceFixture.ShouldBeAssignableTo<BatchHeader>();
            CurrentInstance.ShouldBeAssignableTo<BatchHeader>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (BatchHeader) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_BatchHeader_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            BatchHeader instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (BatchHeader) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyBatchID)]
        [TestCase(PropertyAnyAttr)]
        public void AUT_BatchHeader_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (BatchHeader) => Property (AnyAttr) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_BatchHeader_AnyAttr_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAnyAttr);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyAnyAttr);
            Action currentAction = () => propertyInfo.SetValue(_batchHeaderInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (BatchHeader) => Property (AnyAttr) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_BatchHeader_Public_Class_AnyAttr_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (BatchHeader) => Property (BatchID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_BatchHeader_Public_Class_BatchID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBatchID);
            var propertyInfo = this.GetPropertyInfo(PropertyBatchID);

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