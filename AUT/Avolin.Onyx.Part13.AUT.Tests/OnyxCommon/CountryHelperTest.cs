using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using Shouldly;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.CountryHelper" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CountryHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CountryHelper" />)
        /// </summary>
        public CountryHelperTest() : base(typeof(CountryHelper))
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

        #region General Initializer : Class (CountryHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _countryHelperInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="CountryHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _countryHelperInstanceType = typeof(CountryHelper);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CountryHelper) Initializer

        #region Methods

        private const string MethodloadCountries = "loadCountries";
        private const string MethodgetCountryFromCode = "getCountryFromCode";

        #endregion

        #region Fields

        private const string FieldcountryList = "countryList";

        #endregion

        #endregion

        #region General Initializer : Class (CountryHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CountryHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CountryHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CountryHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CountryHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CountryHelper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CountryHelper)

        #region General Initializer : Class (CountryHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CountryHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodloadCountries, 0)]
        [TestCase(MethodgetCountryFromCode, 0)]
        public void AUT_CountryHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CountryHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CountryHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldcountryList)]
        [Category("AUT Fields")]
        public void AUT_CountryHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CountryHelper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CountryHelper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CountryHelper_Is_Static_Type_Present_Test()
        {
            // Assert
            _countryHelperInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (loadCountries) (Return Type : Dictionary<String,OnyxCountry>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryHelper_loadCountries_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadCountries);

            // Act
            Action executeAction = () => CountryHelper.loadCountries();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (loadCountries) (Return Type : Dictionary<String,OnyxCountry>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryHelper_loadCountries_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadCountries);
            var returnedValue = default(Dictionary<String,OnyxCountry>);

            // Act
            Action executeAction = () => returnedValue = CountryHelper.loadCountries();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (loadCountries) (Return Type : Dictionary<String,OnyxCountry>) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryHelper_loadCountries_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadCountries);
            Type [] methodloadCountriesParametersTypes = null;
            object[] parametersOfloadCountries = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodloadCountries, methodloadCountriesParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodloadCountries, methodloadCountriesParametersTypes);
            var result2 = this.GetResultOfMethod<Dictionary<String,OnyxCountry>>(MethodloadCountries, parametersOfloadCountries, methodloadCountriesParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfloadCountries);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfloadCountries.ShouldBeNull();
            methodloadCountriesParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (loadCountries) (Return Type : Dictionary<String,OnyxCountry>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryHelper_loadCountries_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadCountries);
            Type [] methodloadCountriesParametersTypes = null;
            object[] parametersOfloadCountries = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<Dictionary<String,OnyxCountry>>(MethodloadCountries, parametersOfloadCountries, methodloadCountriesParametersTypes);

            // Assert
            parametersOfloadCountries.ShouldBeNull();
            methodloadCountriesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (loadCountries) (Return Type : Dictionary<String,OnyxCountry>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryHelper_loadCountries_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadCountries);
            Type [] methodloadCountriesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodloadCountries, methodloadCountriesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodloadCountriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (loadCountries) (Return Type : Dictionary<String,OnyxCountry>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryHelper_loadCountries_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadCountries);
            Type [] methodloadCountriesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodloadCountries, methodloadCountriesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodloadCountriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (loadCountries) (Return Type : Dictionary<String,OnyxCountry>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryHelper_loadCountries_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadCountries);
            var currentMethodInfo = this.GetMethodInfo(MethodloadCountries, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getCountryFromCode) (Return Type : OnyxCountry) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CountryHelper_getCountryFromCode_Static_Method_Call_Internally(Type[] types)
        {
            var methodgetCountryFromCodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetCountryFromCode, methodgetCountryFromCodeParametersTypes);
        }

        #endregion

        #region Method Call : (getCountryFromCode) (Return Type : OnyxCountry) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryHelper_getCountryFromCode_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCountryFromCode);
            var countryCode = this.CreateType<string>();

            // Act
            Action executeAction = () => CountryHelper.getCountryFromCode(countryCode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (getCountryFromCode) (Return Type : OnyxCountry) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryHelper_getCountryFromCode_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCountryFromCode);
            var countryCode = this.CreateType<string>();
            var returnedValue = default(OnyxCountry);

            // Act
            Action executeAction = () => returnedValue = CountryHelper.getCountryFromCode(countryCode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getCountryFromCode) (Return Type : OnyxCountry) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryHelper_getCountryFromCode_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCountryFromCode);
            var countryCode = this.CreateType<string>();
            var methodgetCountryFromCodeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfgetCountryFromCode = { countryCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetCountryFromCode, methodgetCountryFromCodeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodgetCountryFromCode, methodgetCountryFromCodeParametersTypes);
            var result2 = this.GetResultOfMethod<OnyxCountry>(MethodgetCountryFromCode, parametersOfgetCountryFromCode, methodgetCountryFromCodeParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfgetCountryFromCode);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetCountryFromCode.ShouldNotBeNull();
            parametersOfgetCountryFromCode.Length.ShouldBe(1);
            methodgetCountryFromCodeParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (getCountryFromCode) (Return Type : OnyxCountry) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryHelper_getCountryFromCode_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCountryFromCode);
            var countryCode = this.CreateType<string>();
            var methodgetCountryFromCodeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfgetCountryFromCode = { countryCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxCountry>(MethodgetCountryFromCode, parametersOfgetCountryFromCode, methodgetCountryFromCodeParametersTypes);

            // Assert
            parametersOfgetCountryFromCode.ShouldNotBeNull();
            parametersOfgetCountryFromCode.Length.ShouldBe(1);
            methodgetCountryFromCodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getCountryFromCode) (Return Type : OnyxCountry) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryHelper_getCountryFromCode_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCountryFromCode);
            var methodgetCountryFromCodeParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetCountryFromCode, methodgetCountryFromCodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetCountryFromCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getCountryFromCode) (Return Type : OnyxCountry) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryHelper_getCountryFromCode_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCountryFromCode);
            var methodgetCountryFromCodeParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetCountryFromCode, methodgetCountryFromCodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetCountryFromCodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getCountryFromCode) (Return Type : OnyxCountry) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryHelper_getCountryFromCode_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCountryFromCode);
            var currentMethodInfo = this.GetMethodInfo(MethodgetCountryFromCode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getCountryFromCode) (Return Type : OnyxCountry) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CountryHelper_getCountryFromCode_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetCountryFromCode);
            var currentMethodInfo = this.GetMethodInfo(MethodgetCountryFromCode, 0);
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