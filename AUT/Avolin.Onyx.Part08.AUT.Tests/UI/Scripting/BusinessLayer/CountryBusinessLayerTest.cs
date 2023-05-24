using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Core.Model;
using Onyx.UI.Scripting.BusinessLayer;
using Onyx.UI.Scripting.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.BusinessLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.BusinessLayer.CountryBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class CountryBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CountryBusinessLayer" />)
        /// </summary>
        public CountryBusinessLayerTest() : base(typeof(CountryBusinessLayer))
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

        #region General Initializer : Class (CountryBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _countryBusinessLayerInstanceType;
        private CountryBusinessLayer _countryBusinessLayerInstance;
        private CountryBusinessLayer _countryBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CountryBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _countryBusinessLayerInstanceType = typeof(CountryBusinessLayer);
            _countryBusinessLayerInstanceFixture = this.Create<CountryBusinessLayer>(false);
            _countryBusinessLayerInstance = _countryBusinessLayerInstanceFixture ?? this.Create<CountryBusinessLayer>(true);
            CurrentInstance = _countryBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CountryBusinessLayer) Initializer

        #region Methods

        private const string MethodGetActiveCountries = "GetActiveCountries";

        #endregion

        #endregion

        #region General Initializer : Class (CountryBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CountryBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CountryBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CountryBusinessLayer) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="CountryBusinessLayer" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CountryBusinessLayer_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CountryBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CountryBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CountryBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CountryBusinessLayer)

        #region General Initializer : Class (CountryBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CountryBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetActiveCountries, 0)]
        public void AUT_CountryBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (CountryBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CountryBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CountryBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _countryBusinessLayerInstanceType.ShouldNotBeNull();
            _countryBusinessLayerInstance.ShouldNotBeNull();
            _countryBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CountryBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CountryBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CountryBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _countryBusinessLayerInstance.ShouldBeAssignableTo<CountryBusinessLayer>();
            _countryBusinessLayerInstanceFixture.ShouldBeAssignableTo<CountryBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<CountryBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CountryBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CountryBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            CountryBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetActiveCountries) (Return Type : IList<CountryModel>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryBusinessLayer_GetActiveCountries_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveCountries);
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _countryBusinessLayerInstance.GetActiveCountries(messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetActiveCountries) (Return Type : IList<CountryModel>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryBusinessLayer_GetActiveCountries_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveCountries);
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IList<CountryModel>);

            // Act
            Action executeAction = () => returnedValue = _countryBusinessLayerInstance.GetActiveCountries(messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveCountries) (Return Type : IList<CountryModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryBusinessLayer_GetActiveCountries_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveCountries);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetActiveCountriesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetActiveCountries = { messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveCountries, methodGetActiveCountriesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<CountryModel>>(_countryBusinessLayerInstanceFixture, parametersOfGetActiveCountries);
            var result2 = this.GetResultOfMethod<IList<CountryModel>>(MethodGetActiveCountries, parametersOfGetActiveCountries, methodGetActiveCountriesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetActiveCountries.ShouldNotBeNull();
            parametersOfGetActiveCountries.Length.ShouldBe(1);
            methodGetActiveCountriesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetActiveCountries) (Return Type : IList<CountryModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryBusinessLayer_GetActiveCountries_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveCountries);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetActiveCountriesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetActiveCountries = { messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<CountryModel>>(MethodGetActiveCountries, parametersOfGetActiveCountries, methodGetActiveCountriesParametersTypes);

            // Assert
            parametersOfGetActiveCountries.ShouldNotBeNull();
            parametersOfGetActiveCountries.Length.ShouldBe(1);
            methodGetActiveCountriesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetActiveCountries) (Return Type : IList<CountryModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryBusinessLayer_GetActiveCountries_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveCountries);
            var methodGetActiveCountriesParametersTypes = new Type[] { typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetActiveCountries, methodGetActiveCountriesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetActiveCountriesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetActiveCountries) (Return Type : IList<CountryModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryBusinessLayer_GetActiveCountries_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveCountries);
            var methodGetActiveCountriesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetActiveCountries, methodGetActiveCountriesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetActiveCountriesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetActiveCountries) (Return Type : IList<CountryModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryBusinessLayer_GetActiveCountries_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveCountries);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveCountries, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveCountries) (Return Type : IList<CountryModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryBusinessLayer_GetActiveCountries_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveCountries);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveCountries, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}