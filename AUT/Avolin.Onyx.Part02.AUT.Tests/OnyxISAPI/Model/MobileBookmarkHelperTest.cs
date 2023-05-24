using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.MobileBookmarkHelper" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MobileBookmarkHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MobileBookmarkHelper" />)
        /// </summary>
        public MobileBookmarkHelperTest() : base(typeof(MobileBookmarkHelper))
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

        #region General Initializer : Class (MobileBookmarkHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _mobileBookmarkHelperInstanceType;
        private MobileBookmarkHelper _mobileBookmarkHelperInstance;
        private MobileBookmarkHelper _mobileBookmarkHelperInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="MobileBookmarkHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _mobileBookmarkHelperInstanceType = typeof(MobileBookmarkHelper);
            _mobileBookmarkHelperInstanceFixture = this.Create<MobileBookmarkHelper>(false);
            _mobileBookmarkHelperInstance = _mobileBookmarkHelperInstanceFixture ?? this.Create<MobileBookmarkHelper>(true);
            CurrentInstance = _mobileBookmarkHelperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (MobileBookmarkHelper) Initializer

        #region Methods

        private const string MethodRunQuery = "RunQuery";
        private const string MethodGetBookMarkCount = "GetBookMarkCount";
        private const string MethodUnsubscribeMobileBookMark = "UnsubscribeMobileBookMark";
        private const string MethodRemoveMobileBookMark = "RemoveMobileBookMark";
        private const string MethodSubscribeMobileBookMark = "SubscribeMobileBookMark";
        private const string MethodGetMobileBookMarks = "GetMobileBookMarks";
        private const string MethodGetBookmarkProfile = "GetBookmarkProfile";
        private const string MethodGetBookmarkEntity = "GetBookmarkEntity";
        private const string MethodGetQueryParameter = "GetQueryParameter";
        private const string MethodGet = "Get";
        private const string MethodFlagToMobileBookMark = "FlagToMobileBookMark";
        private const string MethodGetBookmarkName = "GetBookmarkName";
        private const string MethodAppendPageTitle = "AppendPageTitle";
        private const string MethodIsQueryExist = "IsQueryExist";

        #endregion

        #region Fields

        private const string FieldservicePersistence = "servicePersistence";
        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";

        #endregion

        #endregion

        #region General Initializer : Class (MobileBookmarkHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MobileBookmarkHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MobileBookmarkHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MobileBookmarkHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="MobileBookmarkHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MobileBookmarkHelper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MobileBookmarkHelper)

        #region General Initializer : Class (MobileBookmarkHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="MobileBookmarkHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodRunQuery, 0)]
        [TestCase(MethodGetBookMarkCount, 0)]
        [TestCase(MethodUnsubscribeMobileBookMark, 0)]
        [TestCase(MethodRemoveMobileBookMark, 0)]
        [TestCase(MethodSubscribeMobileBookMark, 0)]
        [TestCase(MethodGetMobileBookMarks, 0)]
        [TestCase(MethodGetBookmarkProfile, 0)]
        [TestCase(MethodGetBookmarkEntity, 0)]
        [TestCase(MethodGetQueryParameter, 0)]
        [TestCase(MethodGet, 0)]
        [TestCase(MethodFlagToMobileBookMark, 0)]
        [TestCase(MethodGetBookmarkName, 0)]
        [TestCase(MethodAppendPageTitle, 0)]
        [TestCase(MethodIsQueryExist, 0)]
        public void AUT_MobileBookmarkHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (MobileBookmarkHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="MobileBookmarkHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldservicePersistence)]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [Category("AUT Fields")]
        public void AUT_MobileBookmarkHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (MobileBookmarkHelper) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MobileBookmarkHelper" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MobileBookmarkHelper_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _mobileBookmarkHelperInstance.ShouldBeAssignableTo<MobileBookmarkHelper>();
            _mobileBookmarkHelperInstanceFixture.ShouldBeAssignableTo<MobileBookmarkHelper>();
            CurrentInstance.ShouldBeAssignableTo<MobileBookmarkHelper>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (RunQuery) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_RunQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRunQuery);
            var getCount = this.CreateType<bool>();

            // Act
            Action executeAction = () => _mobileBookmarkHelperInstance.RunQuery(getCount);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RunQuery) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_RunQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRunQuery);
            var getCount = this.CreateType<bool>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _mobileBookmarkHelperInstance.RunQuery(getCount);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RunQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_RunQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRunQuery);
            var getCount = this.CreateType<bool>();
            var methodRunQueryParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfRunQuery = { getCount };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRunQuery, methodRunQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_mobileBookmarkHelperInstanceFixture, parametersOfRunQuery);
            var result2 = this.GetResultOfMethod<string>(MethodRunQuery, parametersOfRunQuery, methodRunQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRunQuery.ShouldNotBeNull();
            parametersOfRunQuery.Length.ShouldBe(1);
            methodRunQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RunQuery) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_RunQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRunQuery);
            var getCount = this.CreateType<bool>();
            var methodRunQueryParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfRunQuery = { getCount };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRunQuery, parametersOfRunQuery, methodRunQueryParametersTypes);

            // Assert
            parametersOfRunQuery.ShouldNotBeNull();
            parametersOfRunQuery.Length.ShouldBe(1);
            methodRunQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RunQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_RunQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRunQuery);
            var methodRunQueryParametersTypes = new Type[] { typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRunQuery, methodRunQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRunQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RunQuery) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_RunQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRunQuery);
            var methodRunQueryParametersTypes = new Type[] { typeof(bool) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRunQuery, methodRunQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRunQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RunQuery) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_RunQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRunQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodRunQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RunQuery) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_RunQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRunQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodRunQuery, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBookMarkCount) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MobileBookmarkHelper_GetBookMarkCount_Method_Call_Internally(Type[] types)
        {
            var methodGetBookMarkCountParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetBookMarkCount, methodGetBookMarkCountParametersTypes);
        }

        #endregion

        #region Method Call : (GetBookMarkCount) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookMarkCount_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookMarkCount);

            // Act
            Action executeAction = () => _mobileBookmarkHelperInstance.GetBookMarkCount();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetBookMarkCount) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookMarkCount_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookMarkCount);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _mobileBookmarkHelperInstance.GetBookMarkCount();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBookMarkCount) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookMarkCount_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookMarkCount);
            Type [] methodGetBookMarkCountParametersTypes = null;
            object[] parametersOfGetBookMarkCount = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBookMarkCount, methodGetBookMarkCountParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_mobileBookmarkHelperInstanceFixture, parametersOfGetBookMarkCount);
            var result2 = this.GetResultOfMethod<string>(MethodGetBookMarkCount, parametersOfGetBookMarkCount, methodGetBookMarkCountParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetBookMarkCount.ShouldBeNull();
            methodGetBookMarkCountParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBookMarkCount) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookMarkCount_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookMarkCount);
            Type [] methodGetBookMarkCountParametersTypes = null;
            object[] parametersOfGetBookMarkCount = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetBookMarkCount, parametersOfGetBookMarkCount, methodGetBookMarkCountParametersTypes);

            // Assert
            parametersOfGetBookMarkCount.ShouldBeNull();
            methodGetBookMarkCountParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBookMarkCount) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookMarkCount_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookMarkCount);
            Type [] methodGetBookMarkCountParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBookMarkCount, methodGetBookMarkCountParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetBookMarkCountParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBookMarkCount) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookMarkCount_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookMarkCount);
            Type [] methodGetBookMarkCountParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBookMarkCount, methodGetBookMarkCountParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBookMarkCountParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBookMarkCount) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookMarkCount_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookMarkCount);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBookMarkCount, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UnsubscribeMobileBookMark) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MobileBookmarkHelper_UnsubscribeMobileBookMark_Method_Call_Internally(Type[] types)
        {
            var methodUnsubscribeMobileBookMarkParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUnsubscribeMobileBookMark, methodUnsubscribeMobileBookMarkParametersTypes);
        }

        #endregion

        #region Method Call : (UnsubscribeMobileBookMark) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_UnsubscribeMobileBookMark_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnsubscribeMobileBookMark);

            // Act
            Action executeAction = () => _mobileBookmarkHelperInstance.UnsubscribeMobileBookMark();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UnsubscribeMobileBookMark) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_UnsubscribeMobileBookMark_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnsubscribeMobileBookMark);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _mobileBookmarkHelperInstance.UnsubscribeMobileBookMark();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UnsubscribeMobileBookMark) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_UnsubscribeMobileBookMark_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnsubscribeMobileBookMark);
            Type [] methodUnsubscribeMobileBookMarkParametersTypes = null;
            object[] parametersOfUnsubscribeMobileBookMark = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUnsubscribeMobileBookMark, methodUnsubscribeMobileBookMarkParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_mobileBookmarkHelperInstanceFixture, parametersOfUnsubscribeMobileBookMark);
            var result2 = this.GetResultOfMethod<string>(MethodUnsubscribeMobileBookMark, parametersOfUnsubscribeMobileBookMark, methodUnsubscribeMobileBookMarkParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUnsubscribeMobileBookMark.ShouldBeNull();
            methodUnsubscribeMobileBookMarkParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UnsubscribeMobileBookMark) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_UnsubscribeMobileBookMark_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnsubscribeMobileBookMark);
            Type [] methodUnsubscribeMobileBookMarkParametersTypes = null;
            object[] parametersOfUnsubscribeMobileBookMark = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodUnsubscribeMobileBookMark, parametersOfUnsubscribeMobileBookMark, methodUnsubscribeMobileBookMarkParametersTypes);

            // Assert
            parametersOfUnsubscribeMobileBookMark.ShouldBeNull();
            methodUnsubscribeMobileBookMarkParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UnsubscribeMobileBookMark) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_UnsubscribeMobileBookMark_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnsubscribeMobileBookMark);
            Type [] methodUnsubscribeMobileBookMarkParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUnsubscribeMobileBookMark, methodUnsubscribeMobileBookMarkParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUnsubscribeMobileBookMarkParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UnsubscribeMobileBookMark) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_UnsubscribeMobileBookMark_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnsubscribeMobileBookMark);
            Type [] methodUnsubscribeMobileBookMarkParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUnsubscribeMobileBookMark, methodUnsubscribeMobileBookMarkParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUnsubscribeMobileBookMarkParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UnsubscribeMobileBookMark) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_UnsubscribeMobileBookMark_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnsubscribeMobileBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodUnsubscribeMobileBookMark, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveMobileBookMark) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MobileBookmarkHelper_RemoveMobileBookMark_Method_Call_Internally(Type[] types)
        {
            var methodRemoveMobileBookMarkParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveMobileBookMark, methodRemoveMobileBookMarkParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveMobileBookMark) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_RemoveMobileBookMark_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveMobileBookMark);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodRemoveMobileBookMarkParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfRemoveMobileBookMark = { queryId, ownerId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveMobileBookMark, methodRemoveMobileBookMarkParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_mobileBookmarkHelperInstanceFixture, parametersOfRemoveMobileBookMark);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveMobileBookMark.ShouldNotBeNull();
            parametersOfRemoveMobileBookMark.Length.ShouldBe(2);
            methodRemoveMobileBookMarkParametersTypes.Length.ShouldBe(2);
            methodRemoveMobileBookMarkParametersTypes.Length.ShouldBe(parametersOfRemoveMobileBookMark.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveMobileBookMark) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_RemoveMobileBookMark_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveMobileBookMark);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodRemoveMobileBookMarkParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfRemoveMobileBookMark = { queryId, ownerId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveMobileBookMark, parametersOfRemoveMobileBookMark, methodRemoveMobileBookMarkParametersTypes);

            // Assert
            parametersOfRemoveMobileBookMark.ShouldNotBeNull();
            parametersOfRemoveMobileBookMark.Length.ShouldBe(2);
            methodRemoveMobileBookMarkParametersTypes.Length.ShouldBe(2);
            methodRemoveMobileBookMarkParametersTypes.Length.ShouldBe(parametersOfRemoveMobileBookMark.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveMobileBookMark) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_RemoveMobileBookMark_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveMobileBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveMobileBookMark, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveMobileBookMark) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_RemoveMobileBookMark_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveMobileBookMark);
            var methodRemoveMobileBookMarkParametersTypes = new Type[] { typeof(Guid), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveMobileBookMark, methodRemoveMobileBookMarkParametersTypes);

            // Assert
            methodRemoveMobileBookMarkParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveMobileBookMark) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_RemoveMobileBookMark_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveMobileBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveMobileBookMark, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SubscribeMobileBookMark) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MobileBookmarkHelper_SubscribeMobileBookMark_Method_Call_Internally(Type[] types)
        {
            var methodSubscribeMobileBookMarkParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSubscribeMobileBookMark, methodSubscribeMobileBookMarkParametersTypes);
        }

        #endregion

        #region Method Call : (SubscribeMobileBookMark) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_SubscribeMobileBookMark_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSubscribeMobileBookMark);

            // Act
            Action executeAction = () => _mobileBookmarkHelperInstance.SubscribeMobileBookMark();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SubscribeMobileBookMark) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_SubscribeMobileBookMark_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSubscribeMobileBookMark);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _mobileBookmarkHelperInstance.SubscribeMobileBookMark();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SubscribeMobileBookMark) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_SubscribeMobileBookMark_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSubscribeMobileBookMark);
            Type [] methodSubscribeMobileBookMarkParametersTypes = null;
            object[] parametersOfSubscribeMobileBookMark = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSubscribeMobileBookMark, methodSubscribeMobileBookMarkParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_mobileBookmarkHelperInstanceFixture, parametersOfSubscribeMobileBookMark);
            var result2 = this.GetResultOfMethod<string>(MethodSubscribeMobileBookMark, parametersOfSubscribeMobileBookMark, methodSubscribeMobileBookMarkParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSubscribeMobileBookMark.ShouldBeNull();
            methodSubscribeMobileBookMarkParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SubscribeMobileBookMark) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_SubscribeMobileBookMark_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSubscribeMobileBookMark);
            Type [] methodSubscribeMobileBookMarkParametersTypes = null;
            object[] parametersOfSubscribeMobileBookMark = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSubscribeMobileBookMark, parametersOfSubscribeMobileBookMark, methodSubscribeMobileBookMarkParametersTypes);

            // Assert
            parametersOfSubscribeMobileBookMark.ShouldBeNull();
            methodSubscribeMobileBookMarkParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SubscribeMobileBookMark) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_SubscribeMobileBookMark_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSubscribeMobileBookMark);
            Type [] methodSubscribeMobileBookMarkParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSubscribeMobileBookMark, methodSubscribeMobileBookMarkParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSubscribeMobileBookMarkParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SubscribeMobileBookMark) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_SubscribeMobileBookMark_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSubscribeMobileBookMark);
            Type [] methodSubscribeMobileBookMarkParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSubscribeMobileBookMark, methodSubscribeMobileBookMarkParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSubscribeMobileBookMarkParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SubscribeMobileBookMark) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_SubscribeMobileBookMark_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSubscribeMobileBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodSubscribeMobileBookMark, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMobileBookMarks) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MobileBookmarkHelper_GetMobileBookMarks_Method_Call_Internally(Type[] types)
        {
            var methodGetMobileBookMarksParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMobileBookMarks, methodGetMobileBookMarksParametersTypes);
        }

        #endregion

        #region Method Call : (GetMobileBookMarks) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetMobileBookMarks_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMobileBookMarks);

            // Act
            Action executeAction = () => _mobileBookmarkHelperInstance.GetMobileBookMarks();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetMobileBookMarks) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetMobileBookMarks_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMobileBookMarks);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _mobileBookmarkHelperInstance.GetMobileBookMarks();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMobileBookMarks) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetMobileBookMarks_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMobileBookMarks);
            Type [] methodGetMobileBookMarksParametersTypes = null;
            object[] parametersOfGetMobileBookMarks = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMobileBookMarks, methodGetMobileBookMarksParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_mobileBookmarkHelperInstanceFixture, parametersOfGetMobileBookMarks);
            var result2 = this.GetResultOfMethod<string>(MethodGetMobileBookMarks, parametersOfGetMobileBookMarks, methodGetMobileBookMarksParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetMobileBookMarks.ShouldBeNull();
            methodGetMobileBookMarksParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMobileBookMarks) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetMobileBookMarks_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMobileBookMarks);
            Type [] methodGetMobileBookMarksParametersTypes = null;
            object[] parametersOfGetMobileBookMarks = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetMobileBookMarks, parametersOfGetMobileBookMarks, methodGetMobileBookMarksParametersTypes);

            // Assert
            parametersOfGetMobileBookMarks.ShouldBeNull();
            methodGetMobileBookMarksParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMobileBookMarks) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetMobileBookMarks_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMobileBookMarks);
            Type [] methodGetMobileBookMarksParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMobileBookMarks, methodGetMobileBookMarksParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetMobileBookMarksParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMobileBookMarks) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetMobileBookMarks_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMobileBookMarks);
            Type [] methodGetMobileBookMarksParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMobileBookMarks, methodGetMobileBookMarksParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMobileBookMarksParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMobileBookMarks) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetMobileBookMarks_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMobileBookMarks);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMobileBookMarks, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBookmarkProfile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MobileBookmarkHelper_GetBookmarkProfile_Method_Call_Internally(Type[] types)
        {
            var methodGetBookmarkProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetBookmarkProfile, methodGetBookmarkProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetBookmarkProfile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkProfile);
            var queryId = this.CreateType<Guid>();

            // Act
            Action executeAction = () => _mobileBookmarkHelperInstance.GetBookmarkProfile(queryId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetBookmarkProfile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkProfile);
            var queryId = this.CreateType<Guid>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _mobileBookmarkHelperInstance.GetBookmarkProfile(queryId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBookmarkProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkProfile);
            var queryId = this.CreateType<Guid>();
            var methodGetBookmarkProfileParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfGetBookmarkProfile = { queryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBookmarkProfile, methodGetBookmarkProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_mobileBookmarkHelperInstanceFixture, parametersOfGetBookmarkProfile);
            var result2 = this.GetResultOfMethod<string>(MethodGetBookmarkProfile, parametersOfGetBookmarkProfile, methodGetBookmarkProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetBookmarkProfile.ShouldNotBeNull();
            parametersOfGetBookmarkProfile.Length.ShouldBe(1);
            methodGetBookmarkProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetBookmarkProfile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkProfile);
            var queryId = this.CreateType<Guid>();
            var methodGetBookmarkProfileParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfGetBookmarkProfile = { queryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetBookmarkProfile, parametersOfGetBookmarkProfile, methodGetBookmarkProfileParametersTypes);

            // Assert
            parametersOfGetBookmarkProfile.ShouldNotBeNull();
            parametersOfGetBookmarkProfile.Length.ShouldBe(1);
            methodGetBookmarkProfileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBookmarkProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkProfile);
            var methodGetBookmarkProfileParametersTypes = new Type[] { typeof(Guid) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBookmarkProfile, methodGetBookmarkProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetBookmarkProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetBookmarkProfile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkProfile);
            var methodGetBookmarkProfileParametersTypes = new Type[] { typeof(Guid) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBookmarkProfile, methodGetBookmarkProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBookmarkProfileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBookmarkProfile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBookmarkProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBookmarkProfile) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkProfile_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBookmarkProfile, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBookmarkEntity) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MobileBookmarkHelper_GetBookmarkEntity_Method_Call_Internally(Type[] types)
        {
            var methodGetBookmarkEntityParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetBookmarkEntity, methodGetBookmarkEntityParametersTypes);
        }

        #endregion

        #region Method Call : (GetBookmarkEntity) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkEntity_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkEntity);
            var queryId = this.CreateType<Guid>();

            // Act
            Action executeAction = () => _mobileBookmarkHelperInstance.GetBookmarkEntity(queryId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetBookmarkEntity) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkEntity_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkEntity);
            var queryId = this.CreateType<Guid>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _mobileBookmarkHelperInstance.GetBookmarkEntity(queryId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBookmarkEntity) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkEntity_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkEntity);
            var queryId = this.CreateType<Guid>();
            var methodGetBookmarkEntityParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfGetBookmarkEntity = { queryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBookmarkEntity, methodGetBookmarkEntityParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_mobileBookmarkHelperInstanceFixture, parametersOfGetBookmarkEntity);
            var result2 = this.GetResultOfMethod<string>(MethodGetBookmarkEntity, parametersOfGetBookmarkEntity, methodGetBookmarkEntityParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetBookmarkEntity.ShouldNotBeNull();
            parametersOfGetBookmarkEntity.Length.ShouldBe(1);
            methodGetBookmarkEntityParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetBookmarkEntity) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkEntity_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkEntity);
            var queryId = this.CreateType<Guid>();
            var methodGetBookmarkEntityParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfGetBookmarkEntity = { queryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetBookmarkEntity, parametersOfGetBookmarkEntity, methodGetBookmarkEntityParametersTypes);

            // Assert
            parametersOfGetBookmarkEntity.ShouldNotBeNull();
            parametersOfGetBookmarkEntity.Length.ShouldBe(1);
            methodGetBookmarkEntityParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBookmarkEntity) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkEntity_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkEntity);
            var methodGetBookmarkEntityParametersTypes = new Type[] { typeof(Guid) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBookmarkEntity, methodGetBookmarkEntityParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetBookmarkEntityParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetBookmarkEntity) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkEntity_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkEntity);
            var methodGetBookmarkEntityParametersTypes = new Type[] { typeof(Guid) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBookmarkEntity, methodGetBookmarkEntityParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBookmarkEntityParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBookmarkEntity) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkEntity_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkEntity);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBookmarkEntity, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBookmarkEntity) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkEntity_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkEntity);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBookmarkEntity, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryParameter) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MobileBookmarkHelper_GetQueryParameter_Method_Call_Internally(Type[] types)
        {
            var methodGetQueryParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQueryParameter, methodGetQueryParameterParametersTypes);
        }

        #endregion

        #region Method Call : (GetQueryParameter) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetQueryParameter_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryParameter);
            var queryId = this.CreateType<Guid>();

            // Act
            Action executeAction = () => _mobileBookmarkHelperInstance.GetQueryParameter(queryId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryParameter) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetQueryParameter_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryParameter);
            var queryId = this.CreateType<Guid>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _mobileBookmarkHelperInstance.GetQueryParameter(queryId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryParameter) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetQueryParameter_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryParameter);
            var queryId = this.CreateType<Guid>();
            var methodGetQueryParameterParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfGetQueryParameter = { queryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryParameter, methodGetQueryParameterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_mobileBookmarkHelperInstanceFixture, parametersOfGetQueryParameter);
            var result2 = this.GetResultOfMethod<string>(MethodGetQueryParameter, parametersOfGetQueryParameter, methodGetQueryParameterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryParameter.ShouldNotBeNull();
            parametersOfGetQueryParameter.Length.ShouldBe(1);
            methodGetQueryParameterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQueryParameter) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetQueryParameter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryParameter);
            var queryId = this.CreateType<Guid>();
            var methodGetQueryParameterParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfGetQueryParameter = { queryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetQueryParameter, parametersOfGetQueryParameter, methodGetQueryParameterParametersTypes);

            // Assert
            parametersOfGetQueryParameter.ShouldNotBeNull();
            parametersOfGetQueryParameter.Length.ShouldBe(1);
            methodGetQueryParameterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryParameter) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetQueryParameter_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryParameter);
            var methodGetQueryParameterParametersTypes = new Type[] { typeof(Guid) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryParameter, methodGetQueryParameterParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryParameterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQueryParameter) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetQueryParameter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryParameter);
            var methodGetQueryParameterParametersTypes = new Type[] { typeof(Guid) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryParameter, methodGetQueryParameterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryParameterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryParameter) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetQueryParameter_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryParameter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryParameter) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetQueryParameter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryParameter, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MobileBookmarkHelper_Get_Method_Call_Internally(Type[] types)
        {
            var methodGetParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGet, methodGetParametersTypes);
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_Get_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;
            object[] parametersOfGet = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGet, methodGetParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_mobileBookmarkHelperInstanceFixture, parametersOfGet);
            var result2 = this.GetResultOfMethod<string>(MethodGet, parametersOfGet, methodGetParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGet.ShouldBeNull();
            methodGetParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_Get_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;
            object[] parametersOfGet = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGet, parametersOfGet, methodGetParametersTypes);

            // Assert
            parametersOfGet.ShouldBeNull();
            methodGetParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_Get_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGet, methodGetParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_Get_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGet, methodGetParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_Get_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            var currentMethodInfo = this.GetMethodInfo(MethodGet, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FlagToMobileBookMark) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MobileBookmarkHelper_FlagToMobileBookMark_Method_Call_Internally(Type[] types)
        {
            var methodFlagToMobileBookMarkParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFlagToMobileBookMark, methodFlagToMobileBookMarkParametersTypes);
        }

        #endregion

        #region Method Call : (FlagToMobileBookMark) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_FlagToMobileBookMark_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFlagToMobileBookMark);
            var profileDoc = this.CreateType<XDocument>();
            var methodFlagToMobileBookMarkParametersTypes = new Type[] { typeof(XDocument) };
            object[] parametersOfFlagToMobileBookMark = { profileDoc };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodFlagToMobileBookMark, methodFlagToMobileBookMarkParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_mobileBookmarkHelperInstanceFixture, parametersOfFlagToMobileBookMark);
            var result2 = this.GetResultOfMethod<bool>(MethodFlagToMobileBookMark, parametersOfFlagToMobileBookMark, methodFlagToMobileBookMarkParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfFlagToMobileBookMark.ShouldNotBeNull();
            parametersOfFlagToMobileBookMark.Length.ShouldBe(1);
            methodFlagToMobileBookMarkParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (FlagToMobileBookMark) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_FlagToMobileBookMark_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFlagToMobileBookMark);
            var profileDoc = this.CreateType<XDocument>();
            var methodFlagToMobileBookMarkParametersTypes = new Type[] { typeof(XDocument) };
            object[] parametersOfFlagToMobileBookMark = { profileDoc };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodFlagToMobileBookMark, methodFlagToMobileBookMarkParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_mobileBookmarkHelperInstanceFixture, out exception1, parametersOfFlagToMobileBookMark);
            var result2 = this.GetResultOfMethod<bool>(MethodFlagToMobileBookMark, parametersOfFlagToMobileBookMark, methodFlagToMobileBookMarkParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfFlagToMobileBookMark.ShouldNotBeNull();
            parametersOfFlagToMobileBookMark.Length.ShouldBe(1);
            methodFlagToMobileBookMarkParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (FlagToMobileBookMark) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_FlagToMobileBookMark_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFlagToMobileBookMark);
            var profileDoc = this.CreateType<XDocument>();
            var methodFlagToMobileBookMarkParametersTypes = new Type[] { typeof(XDocument) };
            object[] parametersOfFlagToMobileBookMark = { profileDoc };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodFlagToMobileBookMark, parametersOfFlagToMobileBookMark, methodFlagToMobileBookMarkParametersTypes);

            // Assert
            parametersOfFlagToMobileBookMark.ShouldNotBeNull();
            parametersOfFlagToMobileBookMark.Length.ShouldBe(1);
            methodFlagToMobileBookMarkParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FlagToMobileBookMark) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_FlagToMobileBookMark_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFlagToMobileBookMark);
            var methodFlagToMobileBookMarkParametersTypes = new Type[] { typeof(XDocument) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFlagToMobileBookMark, methodFlagToMobileBookMarkParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFlagToMobileBookMarkParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FlagToMobileBookMark) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_FlagToMobileBookMark_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFlagToMobileBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodFlagToMobileBookMark, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FlagToMobileBookMark) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_FlagToMobileBookMark_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFlagToMobileBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodFlagToMobileBookMark, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBookmarkName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MobileBookmarkHelper_GetBookmarkName_Method_Call_Internally(Type[] types)
        {
            var methodGetBookmarkNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetBookmarkName, methodGetBookmarkNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetBookmarkName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkName);
            var queryId = this.CreateType<Guid>();
            var methodGetBookmarkNameParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfGetBookmarkName = { queryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBookmarkName, methodGetBookmarkNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_mobileBookmarkHelperInstanceFixture, parametersOfGetBookmarkName);
            var result2 = this.GetResultOfMethod<string>(MethodGetBookmarkName, parametersOfGetBookmarkName, methodGetBookmarkNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetBookmarkName.ShouldNotBeNull();
            parametersOfGetBookmarkName.Length.ShouldBe(1);
            methodGetBookmarkNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetBookmarkName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkName);
            var queryId = this.CreateType<Guid>();
            var methodGetBookmarkNameParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfGetBookmarkName = { queryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetBookmarkName, parametersOfGetBookmarkName, methodGetBookmarkNameParametersTypes);

            // Assert
            parametersOfGetBookmarkName.ShouldNotBeNull();
            parametersOfGetBookmarkName.Length.ShouldBe(1);
            methodGetBookmarkNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBookmarkName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkName);
            var methodGetBookmarkNameParametersTypes = new Type[] { typeof(Guid) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBookmarkName, methodGetBookmarkNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetBookmarkNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetBookmarkName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkName);
            var methodGetBookmarkNameParametersTypes = new Type[] { typeof(Guid) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBookmarkName, methodGetBookmarkNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBookmarkNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBookmarkName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBookmarkName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBookmarkName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_GetBookmarkName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookmarkName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBookmarkName, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AppendPageTitle) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MobileBookmarkHelper_AppendPageTitle_Method_Call_Internally(Type[] types)
        {
            var methodAppendPageTitleParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAppendPageTitle, methodAppendPageTitleParametersTypes);
        }

        #endregion

        #region Method Call : (AppendPageTitle) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_AppendPageTitle_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendPageTitle);
            var profileDoc = this.CreateType<XDocument>();
            var queryId = this.CreateType<Guid>();
            var methodAppendPageTitleParametersTypes = new Type[] { typeof(XDocument), typeof(Guid) };
            object[] parametersOfAppendPageTitle = { profileDoc, queryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAppendPageTitle, methodAppendPageTitleParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_mobileBookmarkHelperInstanceFixture, parametersOfAppendPageTitle);
            var result2 = this.GetResultOfMethod<bool>(MethodAppendPageTitle, parametersOfAppendPageTitle, methodAppendPageTitleParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAppendPageTitle.ShouldNotBeNull();
            parametersOfAppendPageTitle.Length.ShouldBe(2);
            methodAppendPageTitleParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (AppendPageTitle) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_AppendPageTitle_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendPageTitle);
            var profileDoc = this.CreateType<XDocument>();
            var queryId = this.CreateType<Guid>();
            var methodAppendPageTitleParametersTypes = new Type[] { typeof(XDocument), typeof(Guid) };
            object[] parametersOfAppendPageTitle = { profileDoc, queryId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodAppendPageTitle, methodAppendPageTitleParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_mobileBookmarkHelperInstanceFixture, out exception1, parametersOfAppendPageTitle);
            var result2 = this.GetResultOfMethod<bool>(MethodAppendPageTitle, parametersOfAppendPageTitle, methodAppendPageTitleParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAppendPageTitle.ShouldNotBeNull();
            parametersOfAppendPageTitle.Length.ShouldBe(2);
            methodAppendPageTitleParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (AppendPageTitle) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_AppendPageTitle_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendPageTitle);
            var profileDoc = this.CreateType<XDocument>();
            var queryId = this.CreateType<Guid>();
            var methodAppendPageTitleParametersTypes = new Type[] { typeof(XDocument), typeof(Guid) };
            object[] parametersOfAppendPageTitle = { profileDoc, queryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodAppendPageTitle, parametersOfAppendPageTitle, methodAppendPageTitleParametersTypes);

            // Assert
            parametersOfAppendPageTitle.ShouldNotBeNull();
            parametersOfAppendPageTitle.Length.ShouldBe(2);
            methodAppendPageTitleParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AppendPageTitle) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_AppendPageTitle_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendPageTitle);
            var methodAppendPageTitleParametersTypes = new Type[] { typeof(XDocument), typeof(Guid) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAppendPageTitle, methodAppendPageTitleParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAppendPageTitleParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AppendPageTitle) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_AppendPageTitle_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendPageTitle);
            var currentMethodInfo = this.GetMethodInfo(MethodAppendPageTitle, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AppendPageTitle) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_AppendPageTitle_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendPageTitle);
            var currentMethodInfo = this.GetMethodInfo(MethodAppendPageTitle, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MobileBookmarkHelper_IsQueryExist_Method_Call_Internally(Type[] types)
        {
            var methodIsQueryExistParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsQueryExist, methodIsQueryExistParametersTypes);
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_IsQueryExist_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExist);
            var queryId = this.CreateType<Guid>();

            // Act
            Action executeAction = () => _mobileBookmarkHelperInstance.IsQueryExist(queryId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_IsQueryExist_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExist);
            var queryId = this.CreateType<Guid>();
            var methodIsQueryExistParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfIsQueryExist = { queryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsQueryExist, methodIsQueryExistParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_mobileBookmarkHelperInstanceFixture, parametersOfIsQueryExist);
            var result2 = this.GetResultOfMethod<bool>(MethodIsQueryExist, parametersOfIsQueryExist, methodIsQueryExistParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsQueryExist.ShouldNotBeNull();
            parametersOfIsQueryExist.Length.ShouldBe(1);
            methodIsQueryExistParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_IsQueryExist_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExist);
            var queryId = this.CreateType<Guid>();
            var methodIsQueryExistParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfIsQueryExist = { queryId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsQueryExist, methodIsQueryExistParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_mobileBookmarkHelperInstanceFixture, out exception1, parametersOfIsQueryExist);
            var result2 = this.GetResultOfMethod<bool>(MethodIsQueryExist, parametersOfIsQueryExist, methodIsQueryExistParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsQueryExist.ShouldNotBeNull();
            parametersOfIsQueryExist.Length.ShouldBe(1);
            methodIsQueryExistParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_IsQueryExist_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExist);
            var queryId = this.CreateType<Guid>();
            var methodIsQueryExistParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfIsQueryExist = { queryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsQueryExist, parametersOfIsQueryExist, methodIsQueryExistParametersTypes);

            // Assert
            parametersOfIsQueryExist.ShouldNotBeNull();
            parametersOfIsQueryExist.Length.ShouldBe(1);
            methodIsQueryExistParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_IsQueryExist_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExist);
            var methodIsQueryExistParametersTypes = new Type[] { typeof(Guid) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsQueryExist, methodIsQueryExistParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsQueryExistParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_IsQueryExist_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExist);
            var currentMethodInfo = this.GetMethodInfo(MethodIsQueryExist, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MobileBookmarkHelper_IsQueryExist_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExist);
            var currentMethodInfo = this.GetMethodInfo(MethodIsQueryExist, 0);
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