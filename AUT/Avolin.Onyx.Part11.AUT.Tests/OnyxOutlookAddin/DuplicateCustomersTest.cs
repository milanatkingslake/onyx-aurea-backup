using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.DuplicateCustomers" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DuplicateCustomersTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DuplicateCustomers" />)
        /// </summary>
        public DuplicateCustomersTest() : base(typeof(DuplicateCustomers))
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

        #region General Initializer : Class (DuplicateCustomers) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _duplicateCustomersInstanceType;
        private DuplicateCustomers _duplicateCustomersInstance;
        private DuplicateCustomers _duplicateCustomersInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DuplicateCustomers" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _duplicateCustomersInstanceType = typeof(DuplicateCustomers);
            _duplicateCustomersInstanceFixture = this.Create<DuplicateCustomers>(false);
            _duplicateCustomersInstance = _duplicateCustomersInstanceFixture ?? this.Create<DuplicateCustomers>(true);
            CurrentInstance = _duplicateCustomersInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DuplicateCustomers) Initializer

        #region Methods

        private const string MethodduplicateCustomers_Load = "duplicateCustomers_Load";
        private const string MethodduplicateCustomers_CellClick = "duplicateCustomers_CellClick";

        #endregion

        #region Fields

        private const string Fieldtitle = "title";

        #endregion

        #endregion

        #region General Initializer : Class (DuplicateCustomers) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DuplicateCustomers" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DuplicateCustomers_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DuplicateCustomers) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DuplicateCustomers" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DuplicateCustomers_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DuplicateCustomers)

        #region General Initializer : Class (DuplicateCustomers) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DuplicateCustomers" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodduplicateCustomers_Load, 0)]
        [TestCase(MethodduplicateCustomers_CellClick, 0)]
        public void AUT_DuplicateCustomers_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (DuplicateCustomers) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DuplicateCustomers" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldtitle)]
        [Category("AUT Fields")]
        public void AUT_DuplicateCustomers_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DuplicateCustomers) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DuplicateCustomers" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DuplicateCustomers_Is_Instance_Present_Test()
        {
            // Assert
            _duplicateCustomersInstanceType.ShouldNotBeNull();
            _duplicateCustomersInstance.ShouldNotBeNull();
            _duplicateCustomersInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DuplicateCustomers) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DuplicateCustomers" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DuplicateCustomers_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _duplicateCustomersInstance.ShouldBeAssignableTo<DuplicateCustomers>();
            _duplicateCustomersInstanceFixture.ShouldBeAssignableTo<DuplicateCustomers>();
            CurrentInstance.ShouldBeAssignableTo<DuplicateCustomers>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DuplicateCustomers) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DuplicateCustomers_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var t = this.CreateType<TitleControl>();
            DuplicateCustomers instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DuplicateCustomers(t);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _duplicateCustomersInstance.ShouldNotBeNull();
            _duplicateCustomersInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DuplicateCustomers>();
        }

        #endregion

        #region General Constructor : Class (DuplicateCustomers) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DuplicateCustomers_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var t = this.CreateType<TitleControl>();
            DuplicateCustomers instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DuplicateCustomers(t);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _duplicateCustomersInstance.ShouldNotBeNull();
            _duplicateCustomersInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (duplicateCustomers_Load) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DuplicateCustomers_duplicateCustomers_Load_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodduplicateCustomers_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodduplicateCustomers_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfduplicateCustomers_Load = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodduplicateCustomers_Load, methodduplicateCustomers_LoadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_duplicateCustomersInstanceFixture, parametersOfduplicateCustomers_Load);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfduplicateCustomers_Load.ShouldNotBeNull();
            parametersOfduplicateCustomers_Load.Length.ShouldBe(2);
            methodduplicateCustomers_LoadParametersTypes.Length.ShouldBe(2);
            methodduplicateCustomers_LoadParametersTypes.Length.ShouldBe(parametersOfduplicateCustomers_Load.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (duplicateCustomers_Load) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DuplicateCustomers_duplicateCustomers_Load_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodduplicateCustomers_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodduplicateCustomers_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfduplicateCustomers_Load = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodduplicateCustomers_Load, parametersOfduplicateCustomers_Load, methodduplicateCustomers_LoadParametersTypes);

            // Assert
            parametersOfduplicateCustomers_Load.ShouldNotBeNull();
            parametersOfduplicateCustomers_Load.Length.ShouldBe(2);
            methodduplicateCustomers_LoadParametersTypes.Length.ShouldBe(2);
            methodduplicateCustomers_LoadParametersTypes.Length.ShouldBe(parametersOfduplicateCustomers_Load.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (duplicateCustomers_Load) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DuplicateCustomers_duplicateCustomers_Load_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodduplicateCustomers_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodduplicateCustomers_Load, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (duplicateCustomers_Load) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DuplicateCustomers_duplicateCustomers_Load_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodduplicateCustomers_Load);
            var methodduplicateCustomers_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodduplicateCustomers_Load, methodduplicateCustomers_LoadParametersTypes);

            // Assert
            methodduplicateCustomers_LoadParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (duplicateCustomers_Load) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DuplicateCustomers_duplicateCustomers_Load_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodduplicateCustomers_Load);
            var currentMethodInfo = this.GetMethodInfo(MethodduplicateCustomers_Load, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (duplicateCustomers_CellClick) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DuplicateCustomers_duplicateCustomers_CellClick_Method_Call_Internally(Type[] types)
        {
            var methodduplicateCustomers_CellClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodduplicateCustomers_CellClick, methodduplicateCustomers_CellClickParametersTypes);
        }

        #endregion

        #region Method Call : (duplicateCustomers_CellClick) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DuplicateCustomers_duplicateCustomers_CellClick_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodduplicateCustomers_CellClick);
            var sender = this.CreateType<object>();
            var e = this.CreateType<DataGridViewCellEventArgs>();
            var methodduplicateCustomers_CellClickParametersTypes = new Type[] { typeof(object), typeof(DataGridViewCellEventArgs) };
            object[] parametersOfduplicateCustomers_CellClick = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodduplicateCustomers_CellClick, methodduplicateCustomers_CellClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_duplicateCustomersInstanceFixture, parametersOfduplicateCustomers_CellClick);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfduplicateCustomers_CellClick.ShouldNotBeNull();
            parametersOfduplicateCustomers_CellClick.Length.ShouldBe(2);
            methodduplicateCustomers_CellClickParametersTypes.Length.ShouldBe(2);
            methodduplicateCustomers_CellClickParametersTypes.Length.ShouldBe(parametersOfduplicateCustomers_CellClick.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (duplicateCustomers_CellClick) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DuplicateCustomers_duplicateCustomers_CellClick_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodduplicateCustomers_CellClick);
            var sender = this.CreateType<object>();
            var e = this.CreateType<DataGridViewCellEventArgs>();
            var methodduplicateCustomers_CellClickParametersTypes = new Type[] { typeof(object), typeof(DataGridViewCellEventArgs) };
            object[] parametersOfduplicateCustomers_CellClick = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodduplicateCustomers_CellClick, parametersOfduplicateCustomers_CellClick, methodduplicateCustomers_CellClickParametersTypes);

            // Assert
            parametersOfduplicateCustomers_CellClick.ShouldNotBeNull();
            parametersOfduplicateCustomers_CellClick.Length.ShouldBe(2);
            methodduplicateCustomers_CellClickParametersTypes.Length.ShouldBe(2);
            methodduplicateCustomers_CellClickParametersTypes.Length.ShouldBe(parametersOfduplicateCustomers_CellClick.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (duplicateCustomers_CellClick) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DuplicateCustomers_duplicateCustomers_CellClick_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodduplicateCustomers_CellClick);
            var currentMethodInfo = this.GetMethodInfo(MethodduplicateCustomers_CellClick, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (duplicateCustomers_CellClick) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DuplicateCustomers_duplicateCustomers_CellClick_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodduplicateCustomers_CellClick);
            var methodduplicateCustomers_CellClickParametersTypes = new Type[] { typeof(object), typeof(DataGridViewCellEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodduplicateCustomers_CellClick, methodduplicateCustomers_CellClickParametersTypes);

            // Assert
            methodduplicateCustomers_CellClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (duplicateCustomers_CellClick) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DuplicateCustomers_duplicateCustomers_CellClick_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodduplicateCustomers_CellClick);
            var currentMethodInfo = this.GetMethodInfo(MethodduplicateCustomers_CellClick, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}