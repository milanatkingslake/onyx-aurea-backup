using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.LboConfiguration" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LboConfigurationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboConfiguration" />)
        /// </summary>
        public LboConfigurationTest() : base(typeof(LboConfiguration))
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

        #region General Initializer : Class (LboConfiguration) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboConfigurationInstanceType;
        private LboConfiguration _lboConfigurationInstance;
        private LboConfiguration _lboConfigurationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="LboConfiguration" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboConfigurationInstanceType = typeof(LboConfiguration);
            _lboConfigurationInstanceFixture = this.Create<LboConfiguration>(false);
            _lboConfigurationInstance = _lboConfigurationInstanceFixture ?? this.Create<LboConfiguration>(true);
            CurrentInstance = _lboConfigurationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboConfiguration) Initializer

        #region Methods

        private const string MethodGetLboMappings = "GetLboMappings";

        #endregion

        #region Fields

        private const string FieldservicePersistence = "servicePersistence";

        #endregion

        #endregion

        #region General Initializer : Class (LboConfiguration) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LboConfiguration" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboConfiguration_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (LboConfiguration) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboConfiguration" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboConfiguration_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboConfiguration)

        #region General Initializer : Class (LboConfiguration) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="LboConfiguration" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetLboMappings, 0)]
        public void AUT_LboConfiguration_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (LboConfiguration) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LboConfiguration" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldservicePersistence)]
        [Category("AUT Fields")]
        public void AUT_LboConfiguration_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (LboConfiguration) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="LboConfiguration" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboConfiguration_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _lboConfigurationInstance.ShouldBeAssignableTo<LboConfiguration>();
            _lboConfigurationInstanceFixture.ShouldBeAssignableTo<LboConfiguration>();
            CurrentInstance.ShouldBeAssignableTo<LboConfiguration>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetLboMappings) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboConfiguration_GetLboMappings_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappings);

            // Act
            Action executeAction = () => _lboConfigurationInstance.GetLboMappings();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetLboMappings) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboConfiguration_GetLboMappings_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappings);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _lboConfigurationInstance.GetLboMappings();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMappings) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboConfiguration_GetLboMappings_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappings);
            Type [] methodGetLboMappingsParametersTypes = null;
            object[] parametersOfGetLboMappings = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMappings, methodGetLboMappingsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_lboConfigurationInstanceFixture, parametersOfGetLboMappings);
            var result2 = this.GetResultOfMethod<string>(MethodGetLboMappings, parametersOfGetLboMappings, methodGetLboMappingsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLboMappings.ShouldBeNull();
            methodGetLboMappingsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMappings) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboConfiguration_GetLboMappings_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappings);
            Type [] methodGetLboMappingsParametersTypes = null;
            object[] parametersOfGetLboMappings = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetLboMappings, parametersOfGetLboMappings, methodGetLboMappingsParametersTypes);

            // Assert
            parametersOfGetLboMappings.ShouldBeNull();
            methodGetLboMappingsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLboMappings) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboConfiguration_GetLboMappings_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappings);
            Type [] methodGetLboMappingsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLboMappings, methodGetLboMappingsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLboMappingsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMappings) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboConfiguration_GetLboMappings_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappings);
            Type [] methodGetLboMappingsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLboMappings, methodGetLboMappingsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLboMappingsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMappings) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboConfiguration_GetLboMappings_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappings);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMappings, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}