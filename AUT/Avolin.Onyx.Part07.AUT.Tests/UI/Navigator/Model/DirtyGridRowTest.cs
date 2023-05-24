using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.DirtyGridRow" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DirtyGridRowTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DirtyGridRow" />)
        /// </summary>
        public DirtyGridRowTest() : base(typeof(DirtyGridRow))
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

        #region General Initializer : Class (DirtyGridRow) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _dirtyGridRowInstanceType;
        private DirtyGridRow _dirtyGridRowInstance;
        private DirtyGridRow _dirtyGridRowInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DirtyGridRow" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dirtyGridRowInstanceType = typeof(DirtyGridRow);
            _dirtyGridRowInstanceFixture = this.Create<DirtyGridRow>(false);
            _dirtyGridRowInstance = _dirtyGridRowInstanceFixture ?? this.Create<DirtyGridRow>(true);
            CurrentInstance = _dirtyGridRowInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DirtyGridRow) Initializer

        #region Properties

        private const string PropertyRowRecord = "RowRecord";
        private const string PropertyDirtyProperty = "DirtyProperty";

        #endregion

        #region Fields

        private const string FieldDirtyProperties = "DirtyProperties";

        #endregion

        #endregion

        #region General Initializer : Class (DirtyGridRow) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DirtyGridRow" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DirtyGridRow_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DirtyGridRow) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="DirtyGridRow" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DirtyGridRow_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DirtyGridRow) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DirtyGridRow" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DirtyGridRow_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DirtyGridRow)

        #region General Initializer : Class (DirtyGridRow) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="DirtyGridRow" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyRowRecord)]
        [TestCase(PropertyDirtyProperty)]
        [Category("AUT Property")]
        public void AUT_DirtyGridRow_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (DirtyGridRow) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DirtyGridRow" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldDirtyProperties)]
        [Category("AUT Fields")]
        public void AUT_DirtyGridRow_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DirtyGridRow) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DirtyGridRow" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DirtyGridRow_Is_Instance_Present_Test()
        {
            // Assert
            _dirtyGridRowInstanceType.ShouldNotBeNull();
            _dirtyGridRowInstance.ShouldNotBeNull();
            _dirtyGridRowInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DirtyGridRow) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DirtyGridRow" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DirtyGridRow_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _dirtyGridRowInstance.ShouldBeAssignableTo<DirtyGridRow>();
            _dirtyGridRowInstanceFixture.ShouldBeAssignableTo<DirtyGridRow>();
            CurrentInstance.ShouldBeAssignableTo<DirtyGridRow>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DirtyGridRow) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DirtyGridRow_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DirtyGridRow instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (DirtyGridRow) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DirtyGridRow_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var rowRecord = this.CreateType<object>();
            DirtyGridRow instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DirtyGridRow(rowRecord);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _dirtyGridRowInstance.ShouldNotBeNull();
            _dirtyGridRowInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DirtyGridRow>();
        }

        #endregion

        #region General Constructor : Class (DirtyGridRow) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DirtyGridRow_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var rowRecord = this.CreateType<object>();
            DirtyGridRow instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DirtyGridRow(rowRecord);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _dirtyGridRowInstance.ShouldNotBeNull();
            _dirtyGridRowInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (DirtyGridRow) instance created

        /// <summary>
        ///     Class (<see cref="DirtyGridRow" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DirtyGridRow_Is_Created_Test()
        {
            // Assert
            _dirtyGridRowInstance.ShouldNotBeNull();
            _dirtyGridRowInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DirtyGridRow) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="DirtyGridRow" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_DirtyGridRow_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DirtyGridRow) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="DirtyGridRow" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DirtyGridRow_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (DirtyGridRow) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DirtyGridRow" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DirtyGridRow_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodDirtyGridRowParametersTypes = new Type[] { typeof(object) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDirtyGridRowParametersTypes);
        }

        #endregion

        #region General Constructor : Class (DirtyGridRow) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DirtyGridRow" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DirtyGridRow_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodDirtyGridRowParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDirtyGridRowParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (DirtyGridRow) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyRowRecord)]
        [TestCase(PropertyDirtyProperty)]
        public void AUT_DirtyGridRow_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (DirtyGridRow) => Property (RowRecord) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DirtyGridRow_Public_Class_RowRecord_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRowRecord);
            var propertyInfo = this.GetPropertyInfo(PropertyRowRecord);

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