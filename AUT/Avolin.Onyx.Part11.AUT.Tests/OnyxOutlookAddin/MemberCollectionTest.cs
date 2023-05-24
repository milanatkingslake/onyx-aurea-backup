using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;
using Exception = System.Exception;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.MemberCollection" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MemberCollectionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MemberCollection" />)
        /// </summary>
        public MemberCollectionTest() : base(typeof(MemberCollection))
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

        #region General Initializer : Class (MemberCollection) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _memberCollectionInstanceType;
        private MemberCollection _memberCollectionInstance;
        private MemberCollection _memberCollectionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="MemberCollection" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _memberCollectionInstanceType = typeof(MemberCollection);
            _memberCollectionInstanceFixture = this.Create<MemberCollection>(false);
            _memberCollectionInstance = _memberCollectionInstanceFixture ?? this.Create<MemberCollection>(true);
            CurrentInstance = _memberCollectionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (MemberCollection) Initializer

        #region Methods

        private const string MethodCheckForUnresolvedMembers = "CheckForUnresolvedMembers";
        private const string MethodResolveMember = "ResolveMember";
        private const string MethodSelectRange = "SelectRange";
        private const string MethodResolveAll = "ResolveAll";

        #endregion

        #endregion

        #region General Initializer : Class (MemberCollection) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MemberCollection" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MemberCollection_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MemberCollection)

        #region General Initializer : Class (MemberCollection) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="MemberCollection" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCheckForUnresolvedMembers, 0)]
        [TestCase(MethodResolveMember, 0)]
        [TestCase(MethodSelectRange, 0)]
        [TestCase(MethodResolveAll, 0)]
        public void AUT_MemberCollection_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (MemberCollection) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MemberCollection" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MemberCollection_Is_Instance_Present_Test()
        {
            // Assert
            _memberCollectionInstanceType.ShouldNotBeNull();
            _memberCollectionInstance.ShouldNotBeNull();
            _memberCollectionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MemberCollection) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MemberCollection" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MemberCollection_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _memberCollectionInstance.ShouldBeAssignableTo<MemberCollection>();
            _memberCollectionInstanceFixture.ShouldBeAssignableTo<MemberCollection>();
            CurrentInstance.ShouldBeAssignableTo<MemberCollection>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MemberCollection) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MemberCollection_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            MemberCollection instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (MemberCollection) instance created

        /// <summary>
        ///     Class (<see cref="MemberCollection" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MemberCollection_Is_Created_Test()
        {
            // Assert
            _memberCollectionInstance.ShouldNotBeNull();
            _memberCollectionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (MemberCollection) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="MemberCollection" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        public void AUT_MemberCollection_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (MemberCollection) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="MemberCollection" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MemberCollection_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (MemberCollection) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="MemberCollection" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MemberCollection_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodMemberCollectionParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodMemberCollectionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (MemberCollection) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="MemberCollection" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MemberCollection_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodMemberCollectionParametersTypes = new Type[] { typeof(IEnumerable<Member>) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodMemberCollectionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (MemberCollection) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="MemberCollection" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MemberCollection_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodMemberCollectionParametersTypes = new Type[] { typeof(Object) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodMemberCollectionParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (CheckForUnresolvedMembers) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_CheckForUnresolvedMembers_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckForUnresolvedMembers);

            // Act
            Action executeAction = () => _memberCollectionInstance.CheckForUnresolvedMembers();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CheckForUnresolvedMembers) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_CheckForUnresolvedMembers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckForUnresolvedMembers);
            Type [] methodCheckForUnresolvedMembersParametersTypes = null;
            object[] parametersOfCheckForUnresolvedMembers = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckForUnresolvedMembers, methodCheckForUnresolvedMembersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_memberCollectionInstanceFixture, parametersOfCheckForUnresolvedMembers);
            var result2 = this.GetResultOfMethod<bool>(MethodCheckForUnresolvedMembers, parametersOfCheckForUnresolvedMembers, methodCheckForUnresolvedMembersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCheckForUnresolvedMembers.ShouldBeNull();
            methodCheckForUnresolvedMembersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckForUnresolvedMembers) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_CheckForUnresolvedMembers_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckForUnresolvedMembers);
            Type [] methodCheckForUnresolvedMembersParametersTypes = null;
            object[] parametersOfCheckForUnresolvedMembers = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckForUnresolvedMembers, methodCheckForUnresolvedMembersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_memberCollectionInstanceFixture, out exception1, parametersOfCheckForUnresolvedMembers);
            var result2 = this.GetResultOfMethod<bool>(MethodCheckForUnresolvedMembers, parametersOfCheckForUnresolvedMembers, methodCheckForUnresolvedMembersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCheckForUnresolvedMembers.ShouldBeNull();
            methodCheckForUnresolvedMembersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckForUnresolvedMembers) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_CheckForUnresolvedMembers_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckForUnresolvedMembers);
            Type [] methodCheckForUnresolvedMembersParametersTypes = null;
            object[] parametersOfCheckForUnresolvedMembers = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckForUnresolvedMembers, methodCheckForUnresolvedMembersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_memberCollectionInstanceFixture, parametersOfCheckForUnresolvedMembers);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCheckForUnresolvedMembers.ShouldBeNull();
            methodCheckForUnresolvedMembersParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckForUnresolvedMembers) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_CheckForUnresolvedMembers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckForUnresolvedMembers);
            Type [] methodCheckForUnresolvedMembersParametersTypes = null;
            object[] parametersOfCheckForUnresolvedMembers = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCheckForUnresolvedMembers, parametersOfCheckForUnresolvedMembers, methodCheckForUnresolvedMembersParametersTypes);

            // Assert
            parametersOfCheckForUnresolvedMembers.ShouldBeNull();
            methodCheckForUnresolvedMembersParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckForUnresolvedMembers) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_CheckForUnresolvedMembers_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckForUnresolvedMembers);
            Type [] methodCheckForUnresolvedMembersParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckForUnresolvedMembers, methodCheckForUnresolvedMembersParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCheckForUnresolvedMembersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckForUnresolvedMembers) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_CheckForUnresolvedMembers_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckForUnresolvedMembers);
            Type [] methodCheckForUnresolvedMembersParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckForUnresolvedMembers, methodCheckForUnresolvedMembersParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCheckForUnresolvedMembersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckForUnresolvedMembers) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_CheckForUnresolvedMembers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckForUnresolvedMembers);
            Type [] methodCheckForUnresolvedMembersParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckForUnresolvedMembers, methodCheckForUnresolvedMembersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCheckForUnresolvedMembersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckForUnresolvedMembers) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_CheckForUnresolvedMembers_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckForUnresolvedMembers);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckForUnresolvedMembers, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ResolveMember) (Return Type : Member) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MemberCollection_ResolveMember_Method_Call_Internally(Type[] types)
        {
            var methodResolveMemberParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResolveMember, methodResolveMemberParametersTypes);
        }

        #endregion

        #region Method Call : (ResolveMember) (Return Type : Member) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_ResolveMember_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveMember);
            var email = this.CreateType<string>();

            // Act
            Action executeAction = () => _memberCollectionInstance.ResolveMember(email);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ResolveMember) (Return Type : Member) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_ResolveMember_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveMember);
            var email = this.CreateType<string>();
            var returnedValue = default(Member);

            // Act
            Action executeAction = () => returnedValue = _memberCollectionInstance.ResolveMember(email);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResolveMember) (Return Type : Member) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_ResolveMember_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveMember);
            var email = this.CreateType<string>();
            var methodResolveMemberParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfResolveMember = { email };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodResolveMember, methodResolveMemberParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Member>(_memberCollectionInstanceFixture, parametersOfResolveMember);
            var result2 = this.GetResultOfMethod<Member>(MethodResolveMember, parametersOfResolveMember, methodResolveMemberParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfResolveMember.ShouldNotBeNull();
            parametersOfResolveMember.Length.ShouldBe(1);
            methodResolveMemberParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ResolveMember) (Return Type : Member) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_ResolveMember_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveMember);
            var email = this.CreateType<string>();
            var methodResolveMemberParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfResolveMember = { email };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodResolveMember, methodResolveMemberParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_memberCollectionInstanceFixture, parametersOfResolveMember);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfResolveMember.ShouldNotBeNull();
            parametersOfResolveMember.Length.ShouldBe(1);
            methodResolveMemberParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResolveMember) (Return Type : Member) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_ResolveMember_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveMember);
            var email = this.CreateType<string>();
            var methodResolveMemberParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfResolveMember = { email };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Member>(MethodResolveMember, parametersOfResolveMember, methodResolveMemberParametersTypes);

            // Assert
            parametersOfResolveMember.ShouldNotBeNull();
            parametersOfResolveMember.Length.ShouldBe(1);
            methodResolveMemberParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResolveMember) (Return Type : Member) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_ResolveMember_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveMember);
            var methodResolveMemberParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodResolveMember, methodResolveMemberParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodResolveMemberParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ResolveMember) (Return Type : Member) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_ResolveMember_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveMember);
            var methodResolveMemberParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResolveMember, methodResolveMemberParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodResolveMemberParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResolveMember) (Return Type : Member) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_ResolveMember_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveMember);
            var currentMethodInfo = this.GetMethodInfo(MethodResolveMember, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResolveMember) (Return Type : Member) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_ResolveMember_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveMember);
            var currentMethodInfo = this.GetMethodInfo(MethodResolveMember, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SelectRange) (Return Type : MemberCollection) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MemberCollection_SelectRange_Method_Call_Internally(Type[] types)
        {
            var methodSelectRangeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSelectRange, methodSelectRangeParametersTypes);
        }

        #endregion

        #region Method Call : (SelectRange) (Return Type : MemberCollection) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_SelectRange_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectRange);
            var start = this.CreateType<int>();
            var count = this.CreateType<int>();

            // Act
            Action executeAction = () => _memberCollectionInstance.SelectRange(start, count);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SelectRange) (Return Type : MemberCollection) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_SelectRange_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectRange);
            var start = this.CreateType<int>();
            var count = this.CreateType<int>();
            var returnedValue = default(MemberCollection);

            // Act
            Action executeAction = () => returnedValue = _memberCollectionInstance.SelectRange(start, count);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SelectRange) (Return Type : MemberCollection) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_SelectRange_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectRange);
            var start = this.CreateType<int>();
            var count = this.CreateType<int>();
            var methodSelectRangeParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfSelectRange = { start, count };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSelectRange, methodSelectRangeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<MemberCollection>(_memberCollectionInstanceFixture, out exception1, parametersOfSelectRange);
            var result2 = this.GetResultOfMethod<MemberCollection>(MethodSelectRange, parametersOfSelectRange, methodSelectRangeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSelectRange.ShouldNotBeNull();
            parametersOfSelectRange.Length.ShouldBe(2);
            methodSelectRangeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (SelectRange) (Return Type : MemberCollection) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_SelectRange_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectRange);
            var start = this.CreateType<int>();
            var count = this.CreateType<int>();
            var methodSelectRangeParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfSelectRange = { start, count };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSelectRange, methodSelectRangeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_memberCollectionInstanceFixture, parametersOfSelectRange);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSelectRange.ShouldNotBeNull();
            parametersOfSelectRange.Length.ShouldBe(2);
            methodSelectRangeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SelectRange) (Return Type : MemberCollection) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_SelectRange_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectRange);
            var start = this.CreateType<int>();
            var count = this.CreateType<int>();
            var methodSelectRangeParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfSelectRange = { start, count };

            // Act
            Action currentAction = () => this.GetResultOfMethod<MemberCollection>(MethodSelectRange, parametersOfSelectRange, methodSelectRangeParametersTypes);

            // Assert
            parametersOfSelectRange.ShouldNotBeNull();
            parametersOfSelectRange.Length.ShouldBe(2);
            methodSelectRangeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SelectRange) (Return Type : MemberCollection) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_SelectRange_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectRange);
            var methodSelectRangeParametersTypes = new Type[] { typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSelectRange, methodSelectRangeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSelectRangeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (SelectRange) (Return Type : MemberCollection) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_SelectRange_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectRange);
            var methodSelectRangeParametersTypes = new Type[] { typeof(int), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSelectRange, methodSelectRangeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSelectRangeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SelectRange) (Return Type : MemberCollection) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_SelectRange_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectRange);
            var currentMethodInfo = this.GetMethodInfo(MethodSelectRange, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SelectRange) (Return Type : MemberCollection) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_SelectRange_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSelectRange);
            var currentMethodInfo = this.GetMethodInfo(MethodSelectRange, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResolveAll) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MemberCollection_ResolveAll_Method_Call_Internally(Type[] types)
        {
            var methodResolveAllParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResolveAll, methodResolveAllParametersTypes);
        }

        #endregion

        #region Method Call : (ResolveAll) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_ResolveAll_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveAll);

            // Act
            Action executeAction = () => _memberCollectionInstance.ResolveAll();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ResolveAll) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_ResolveAll_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveAll);
            Type [] methodResolveAllParametersTypes = null;
            object[] parametersOfResolveAll = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodResolveAll, methodResolveAllParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_memberCollectionInstanceFixture, parametersOfResolveAll);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfResolveAll.ShouldBeNull();
            methodResolveAllParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResolveAll) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_ResolveAll_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveAll);
            Type [] methodResolveAllParametersTypes = null;
            object[] parametersOfResolveAll = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodResolveAll, parametersOfResolveAll, methodResolveAllParametersTypes);

            // Assert
            parametersOfResolveAll.ShouldBeNull();
            methodResolveAllParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResolveAll) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_ResolveAll_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveAll);
            Type [] methodResolveAllParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResolveAll, methodResolveAllParametersTypes);

            // Assert
            methodResolveAllParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResolveAll) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MemberCollection_ResolveAll_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveAll);
            var currentMethodInfo = this.GetMethodInfo(MethodResolveAll, 0);

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