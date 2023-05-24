using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.Member" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MemberTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Member" />)
        /// </summary>
        public MemberTest() : base(typeof(Member))
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

        #region General Initializer : Class (Member) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _memberInstanceType;
        private Member _memberInstance;
        private Member _memberInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Member" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _memberInstanceType = typeof(Member);
            _memberInstanceFixture = this.Create<Member>(false);
            _memberInstance = _memberInstanceFixture ?? this.Create<Member>(true);
            CurrentInstance = _memberInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Member) Initializer

        #region Properties

        private const string PropertyName = "Name";
        private const string PropertyEmail = "Email";
        private const string PropertyIsSender = "IsSender";
        private const string PropertyIsExpand = "IsExpand";
        private const string PropertyIsResolvedFromOnyx = "IsResolvedFromOnyx";
        private const string PropertyIsCustomer = "IsCustomer";
        private const string PropertyIsInternalUser = "IsInternalUser";
        private const string PropertyId = "Id";
        private const string PropertymatchedOnyxIndividuals = "matchedOnyxIndividuals";
        private const string PropertymatchedOnyxUsers = "matchedOnyxUsers";
        private const string PropertyresolvedInternalUser = "resolvedInternalUser";
        private const string PropertyresolvedIndividual = "resolvedIndividual";
        private const string PropertyIsSameEmailDomain = "IsSameEmailDomain";

        #endregion

        #region Methods

        private const string MethodSetResolvedIndividual = "SetResolvedIndividual";
        private const string MethodSetResolveduser = "SetResolveduser";
        private const string MethodResolve = "Resolve";
        private const string MethodGetIndividualFromPrimaryId = "GetIndividualFromPrimaryId";
        private const string MethodRemoveIndividuals = "RemoveIndividuals";
        private const string MethodRemoveUsers = "RemoveUsers";
        private const string MethodAddIndividual = "AddIndividual";
        private const string MethodAddInternalUser = "AddInternalUser";

        #endregion

        #region Fields

        private const string Fieldcname = "cname";
        private const string Fieldcemail = "cemail";
        private const string FieldisSender = "isSender";
        private const string FieldisExpand = "isExpand";
        private const string FieldisSameDomain = "isSameDomain";
        private const string FieldresolvedIndividualName = "resolvedIndividualName";
        private const string FieldresolvedUserName = "resolvedUserName";
        private const string FieldmatchedIndividuals = "matchedIndividuals";
        private const string FieldmatchedUsers = "matchedUsers";

        #endregion

        #endregion

        #region General Initializer : Class (Member) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Member" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Member_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Member) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Member" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Member_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Member) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Member" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Member_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Member)

        #region General Initializer : Class (Member) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Member" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodSetResolvedIndividual, 0)]
        [TestCase(MethodSetResolveduser, 0)]
        [TestCase(MethodResolve, 0)]
        [TestCase(MethodGetIndividualFromPrimaryId, 0)]
        [TestCase(MethodRemoveIndividuals, 0)]
        [TestCase(MethodRemoveUsers, 0)]
        [TestCase(MethodAddIndividual, 0)]
        [TestCase(MethodAddInternalUser, 0)]
        public void AUT_Member_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Member) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Member" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyName)]
        [TestCase(PropertyEmail)]
        [TestCase(PropertyIsSender)]
        [TestCase(PropertyIsExpand)]
        [TestCase(PropertyIsResolvedFromOnyx)]
        [TestCase(PropertyIsCustomer)]
        [TestCase(PropertyIsInternalUser)]
        [TestCase(PropertyId)]
        [TestCase(PropertymatchedOnyxIndividuals)]
        [TestCase(PropertymatchedOnyxUsers)]
        [TestCase(PropertyresolvedInternalUser)]
        [TestCase(PropertyresolvedIndividual)]
        [TestCase(PropertyIsSameEmailDomain)]
        [Category("AUT Property")]
        public void AUT_Member_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Member) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Member" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcname)]
        [TestCase(Fieldcemail)]
        [TestCase(FieldisSender)]
        [TestCase(FieldisExpand)]
        [TestCase(FieldisSameDomain)]
        [TestCase(FieldresolvedIndividualName)]
        [TestCase(FieldresolvedUserName)]
        [TestCase(FieldmatchedIndividuals)]
        [TestCase(FieldmatchedUsers)]
        [Category("AUT Fields")]
        public void AUT_Member_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Member) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Member" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Member_Is_Instance_Present_Test()
        {
            // Assert
            _memberInstanceType.ShouldNotBeNull();
            _memberInstance.ShouldNotBeNull();
            _memberInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Member) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Member" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Member_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _memberInstance.ShouldBeAssignableTo<Member>();
            _memberInstanceFixture.ShouldBeAssignableTo<Member>();
            CurrentInstance.ShouldBeAssignableTo<Member>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Member) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Member_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var name = this.CreateType<string>();
            var email = this.CreateType<string>();
            var resolve = false;
            Member instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Member(name, email, resolve);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _memberInstance.ShouldNotBeNull();
            _memberInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Member>();
        }

        #endregion

        #region General Constructor : Class (Member) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Member_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var name = this.CreateType<string>();
            var email = this.CreateType<string>();
            var resolve = false;
            Member instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Member(name, email, resolve);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _memberInstance.ShouldNotBeNull();
            _memberInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (Member) instance created

        /// <summary>
        ///     Class (<see cref="Member" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Member_Is_Created_Test()
        {
            // Assert
            _memberInstance.ShouldNotBeNull();
            _memberInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (Member) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="Member" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void AUT_Member_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (Member) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="Member" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Member_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (Member) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Member" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Member_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodMemberParametersTypes = new Type[] { typeof(String), typeof(String), typeof(bool) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodMemberParametersTypes);
        }

        #endregion

        #region General Constructor : Class (Member) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Member" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Member_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodMemberParametersTypes = new Type[] { typeof(OnyxUser) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodMemberParametersTypes);
        }

        #endregion

        #region General Constructor : Class (Member) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Member" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Member_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodMemberParametersTypes = new Type[] { typeof(OnyxIndividual) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodMemberParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (Member) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyName)]
        [TestCase(PropertyEmail)]
        [TestCase(PropertyIsSender)]
        [TestCase(PropertyIsExpand)]
        [TestCase(PropertyIsResolvedFromOnyx)]
        [TestCase(PropertyIsCustomer)]
        [TestCase(PropertyIsInternalUser)]
        [TestCase(PropertyId)]
        [TestCase(PropertymatchedOnyxIndividuals)]
        [TestCase(PropertymatchedOnyxUsers)]
        [TestCase(PropertyresolvedInternalUser)]
        [TestCase(PropertyresolvedIndividual)]
        [TestCase(PropertyIsSameEmailDomain)]
        public void AUT_Member_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (Member) => Property (Email) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_Public_Class_Email_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEmail);
            var propertyInfo = this.GetPropertyInfo(PropertyEmail);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Member) => Property (Id) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_Id_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyId);
            Action currentAction = () => propertyInfo.SetValue(_memberInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Member) => Property (Id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_Public_Class_Id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyId);
            var propertyInfo = this.GetPropertyInfo(PropertyId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Member) => Property (IsCustomer) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_Public_Class_IsCustomer_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsCustomer);
            var propertyInfo = this.GetPropertyInfo(PropertyIsCustomer);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Member) => Property (IsExpand) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_Public_Class_IsExpand_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsExpand);
            var propertyInfo = this.GetPropertyInfo(PropertyIsExpand);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Member) => Property (IsInternalUser) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_Public_Class_IsInternalUser_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsInternalUser);
            var propertyInfo = this.GetPropertyInfo(PropertyIsInternalUser);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Member) => Property (IsResolvedFromOnyx) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_Public_Class_IsResolvedFromOnyx_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsResolvedFromOnyx);
            var propertyInfo = this.GetPropertyInfo(PropertyIsResolvedFromOnyx);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Member) => Property (IsSameEmailDomain) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_Public_Class_IsSameEmailDomain_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsSameEmailDomain);
            var propertyInfo = this.GetPropertyInfo(PropertyIsSameEmailDomain);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Member) => Property (IsSender) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_Public_Class_IsSender_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsSender);
            var propertyInfo = this.GetPropertyInfo(PropertyIsSender);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Member) => Property (matchedOnyxIndividuals) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_Public_Class_matchedOnyxIndividuals_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertymatchedOnyxIndividuals);
            var propertyInfo = this.GetPropertyInfo(PropertymatchedOnyxIndividuals);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Member) => Property (matchedOnyxUsers) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_Public_Class_matchedOnyxUsers_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertymatchedOnyxUsers);
            var propertyInfo = this.GetPropertyInfo(PropertymatchedOnyxUsers);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Member) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyName);
            var propertyInfo = this.GetPropertyInfo(PropertyName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Member) => Property (resolvedIndividual) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_resolvedIndividual_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyresolvedIndividual);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyresolvedIndividual);
            Action currentAction = () => propertyInfo.SetValue(_memberInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Member) => Property (resolvedIndividual) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_Public_Class_resolvedIndividual_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyresolvedIndividual);
            var propertyInfo = this.GetPropertyInfo(PropertyresolvedIndividual);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Member) => Property (resolvedInternalUser) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_resolvedInternalUser_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyresolvedInternalUser);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyresolvedInternalUser);
            Action currentAction = () => propertyInfo.SetValue(_memberInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Member) => Property (resolvedInternalUser) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Member_Public_Class_resolvedInternalUser_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyresolvedInternalUser);
            var propertyInfo = this.GetPropertyInfo(PropertyresolvedInternalUser);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (SetResolvedIndividual) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_SetResolvedIndividual_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResolvedIndividual);
            var ind = this.CreateType<OnyxIndividual>();

            // Act
            Action executeAction = () => _memberInstance.SetResolvedIndividual(ind);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetResolvedIndividual) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_SetResolvedIndividual_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResolvedIndividual);
            var ind = this.CreateType<OnyxIndividual>();
            var methodSetResolvedIndividualParametersTypes = new Type[] { typeof(OnyxIndividual) };
            object[] parametersOfSetResolvedIndividual = { ind };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResolvedIndividual, methodSetResolvedIndividualParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_memberInstanceFixture, parametersOfSetResolvedIndividual);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetResolvedIndividual.ShouldNotBeNull();
            parametersOfSetResolvedIndividual.Length.ShouldBe(1);
            methodSetResolvedIndividualParametersTypes.Length.ShouldBe(1);
            methodSetResolvedIndividualParametersTypes.Length.ShouldBe(parametersOfSetResolvedIndividual.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResolvedIndividual) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_SetResolvedIndividual_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResolvedIndividual);
            var ind = this.CreateType<OnyxIndividual>();
            var methodSetResolvedIndividualParametersTypes = new Type[] { typeof(OnyxIndividual) };
            object[] parametersOfSetResolvedIndividual = { ind };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetResolvedIndividual, parametersOfSetResolvedIndividual, methodSetResolvedIndividualParametersTypes);

            // Assert
            parametersOfSetResolvedIndividual.ShouldNotBeNull();
            parametersOfSetResolvedIndividual.Length.ShouldBe(1);
            methodSetResolvedIndividualParametersTypes.Length.ShouldBe(1);
            methodSetResolvedIndividualParametersTypes.Length.ShouldBe(parametersOfSetResolvedIndividual.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResolvedIndividual) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_SetResolvedIndividual_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResolvedIndividual);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResolvedIndividual, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetResolvedIndividual) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_SetResolvedIndividual_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResolvedIndividual);
            var methodSetResolvedIndividualParametersTypes = new Type[] { typeof(OnyxIndividual) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetResolvedIndividual, methodSetResolvedIndividualParametersTypes);

            // Assert
            methodSetResolvedIndividualParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResolvedIndividual) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_SetResolvedIndividual_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResolvedIndividual);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResolvedIndividual, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResolveduser) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Member_SetResolveduser_Method_Call_Internally(Type[] types)
        {
            var methodSetResolveduserParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetResolveduser, methodSetResolveduserParametersTypes);
        }

        #endregion

        #region Method Call : (SetResolveduser) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_SetResolveduser_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResolveduser);
            var user = this.CreateType<OnyxUser>();

            // Act
            Action executeAction = () => _memberInstance.SetResolveduser(user);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetResolveduser) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_SetResolveduser_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResolveduser);
            var user = this.CreateType<OnyxUser>();
            var methodSetResolveduserParametersTypes = new Type[] { typeof(OnyxUser) };
            object[] parametersOfSetResolveduser = { user };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResolveduser, methodSetResolveduserParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_memberInstanceFixture, parametersOfSetResolveduser);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetResolveduser.ShouldNotBeNull();
            parametersOfSetResolveduser.Length.ShouldBe(1);
            methodSetResolveduserParametersTypes.Length.ShouldBe(1);
            methodSetResolveduserParametersTypes.Length.ShouldBe(parametersOfSetResolveduser.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResolveduser) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_SetResolveduser_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResolveduser);
            var user = this.CreateType<OnyxUser>();
            var methodSetResolveduserParametersTypes = new Type[] { typeof(OnyxUser) };
            object[] parametersOfSetResolveduser = { user };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetResolveduser, parametersOfSetResolveduser, methodSetResolveduserParametersTypes);

            // Assert
            parametersOfSetResolveduser.ShouldNotBeNull();
            parametersOfSetResolveduser.Length.ShouldBe(1);
            methodSetResolveduserParametersTypes.Length.ShouldBe(1);
            methodSetResolveduserParametersTypes.Length.ShouldBe(parametersOfSetResolveduser.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResolveduser) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_SetResolveduser_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResolveduser);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResolveduser, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetResolveduser) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_SetResolveduser_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResolveduser);
            var methodSetResolveduserParametersTypes = new Type[] { typeof(OnyxUser) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetResolveduser, methodSetResolveduserParametersTypes);

            // Assert
            methodSetResolveduserParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResolveduser) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_SetResolveduser_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResolveduser);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResolveduser, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Resolve) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Member_Resolve_Method_Call_Internally(Type[] types)
        {
            var methodResolveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResolve, methodResolveParametersTypes);
        }

        #endregion

        #region Method Call : (Resolve) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_Resolve_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolve);

            // Act
            Action executeAction = () => _memberInstance.Resolve();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Resolve) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_Resolve_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolve);
            Type [] methodResolveParametersTypes = null;
            object[] parametersOfResolve = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodResolve, methodResolveParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_memberInstanceFixture, parametersOfResolve);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfResolve.ShouldBeNull();
            methodResolveParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Resolve) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_Resolve_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolve);
            Type [] methodResolveParametersTypes = null;
            object[] parametersOfResolve = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodResolve, parametersOfResolve, methodResolveParametersTypes);

            // Assert
            parametersOfResolve.ShouldBeNull();
            methodResolveParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Resolve) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_Resolve_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolve);
            Type [] methodResolveParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResolve, methodResolveParametersTypes);

            // Assert
            methodResolveParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Resolve) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_Resolve_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolve);
            var currentMethodInfo = this.GetMethodInfo(MethodResolve, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIndividualFromPrimaryId) (Return Type : OnyxIndividual) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Member_GetIndividualFromPrimaryId_Method_Call_Internally(Type[] types)
        {
            var methodGetIndividualFromPrimaryIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIndividualFromPrimaryId, methodGetIndividualFromPrimaryIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetIndividualFromPrimaryId) (Return Type : OnyxIndividual) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_GetIndividualFromPrimaryId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualFromPrimaryId);
            var primaryId = this.CreateType<string>();

            // Act
            Action executeAction = () => _memberInstance.GetIndividualFromPrimaryId(primaryId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIndividualFromPrimaryId) (Return Type : OnyxIndividual) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_GetIndividualFromPrimaryId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualFromPrimaryId);
            var primaryId = this.CreateType<string>();
            var returnedValue = default(OnyxIndividual);

            // Act
            Action executeAction = () => returnedValue = _memberInstance.GetIndividualFromPrimaryId(primaryId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualFromPrimaryId) (Return Type : OnyxIndividual) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_GetIndividualFromPrimaryId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualFromPrimaryId);
            var primaryId = this.CreateType<string>();
            var methodGetIndividualFromPrimaryIdParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfGetIndividualFromPrimaryId = { primaryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualFromPrimaryId, methodGetIndividualFromPrimaryIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OnyxIndividual>(_memberInstanceFixture, parametersOfGetIndividualFromPrimaryId);
            var result2 = this.GetResultOfMethod<OnyxIndividual>(MethodGetIndividualFromPrimaryId, parametersOfGetIndividualFromPrimaryId, methodGetIndividualFromPrimaryIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIndividualFromPrimaryId.ShouldNotBeNull();
            parametersOfGetIndividualFromPrimaryId.Length.ShouldBe(1);
            methodGetIndividualFromPrimaryIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIndividualFromPrimaryId) (Return Type : OnyxIndividual) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_GetIndividualFromPrimaryId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualFromPrimaryId);
            var primaryId = this.CreateType<string>();
            var methodGetIndividualFromPrimaryIdParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfGetIndividualFromPrimaryId = { primaryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxIndividual>(MethodGetIndividualFromPrimaryId, parametersOfGetIndividualFromPrimaryId, methodGetIndividualFromPrimaryIdParametersTypes);

            // Assert
            parametersOfGetIndividualFromPrimaryId.ShouldNotBeNull();
            parametersOfGetIndividualFromPrimaryId.Length.ShouldBe(1);
            methodGetIndividualFromPrimaryIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIndividualFromPrimaryId) (Return Type : OnyxIndividual) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_GetIndividualFromPrimaryId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualFromPrimaryId);
            var methodGetIndividualFromPrimaryIdParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIndividualFromPrimaryId, methodGetIndividualFromPrimaryIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIndividualFromPrimaryIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIndividualFromPrimaryId) (Return Type : OnyxIndividual) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_GetIndividualFromPrimaryId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualFromPrimaryId);
            var methodGetIndividualFromPrimaryIdParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIndividualFromPrimaryId, methodGetIndividualFromPrimaryIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIndividualFromPrimaryIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIndividualFromPrimaryId) (Return Type : OnyxIndividual) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_GetIndividualFromPrimaryId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualFromPrimaryId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualFromPrimaryId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualFromPrimaryId) (Return Type : OnyxIndividual) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_GetIndividualFromPrimaryId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualFromPrimaryId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualFromPrimaryId, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveIndividuals) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Member_RemoveIndividuals_Method_Call_Internally(Type[] types)
        {
            var methodRemoveIndividualsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveIndividuals, methodRemoveIndividualsParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveIndividuals) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_RemoveIndividuals_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveIndividuals);

            // Act
            Action executeAction = () => _memberInstance.RemoveIndividuals();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveIndividuals) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_RemoveIndividuals_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveIndividuals);
            Type [] methodRemoveIndividualsParametersTypes = null;
            object[] parametersOfRemoveIndividuals = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveIndividuals, methodRemoveIndividualsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_memberInstanceFixture, parametersOfRemoveIndividuals);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveIndividuals.ShouldBeNull();
            methodRemoveIndividualsParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveIndividuals) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_RemoveIndividuals_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveIndividuals);
            Type [] methodRemoveIndividualsParametersTypes = null;
            object[] parametersOfRemoveIndividuals = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveIndividuals, parametersOfRemoveIndividuals, methodRemoveIndividualsParametersTypes);

            // Assert
            parametersOfRemoveIndividuals.ShouldBeNull();
            methodRemoveIndividualsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveIndividuals) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_RemoveIndividuals_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveIndividuals);
            Type [] methodRemoveIndividualsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveIndividuals, methodRemoveIndividualsParametersTypes);

            // Assert
            methodRemoveIndividualsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveIndividuals) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_RemoveIndividuals_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveIndividuals);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveIndividuals, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveUsers) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Member_RemoveUsers_Method_Call_Internally(Type[] types)
        {
            var methodRemoveUsersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveUsers, methodRemoveUsersParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveUsers) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_RemoveUsers_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveUsers);

            // Act
            Action executeAction = () => _memberInstance.RemoveUsers();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveUsers) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_RemoveUsers_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveUsers);
            Type [] methodRemoveUsersParametersTypes = null;
            object[] parametersOfRemoveUsers = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveUsers, methodRemoveUsersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_memberInstanceFixture, parametersOfRemoveUsers);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveUsers.ShouldBeNull();
            methodRemoveUsersParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveUsers) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_RemoveUsers_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveUsers);
            Type [] methodRemoveUsersParametersTypes = null;
            object[] parametersOfRemoveUsers = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveUsers, parametersOfRemoveUsers, methodRemoveUsersParametersTypes);

            // Assert
            parametersOfRemoveUsers.ShouldBeNull();
            methodRemoveUsersParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveUsers) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_RemoveUsers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveUsers);
            Type [] methodRemoveUsersParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveUsers, methodRemoveUsersParametersTypes);

            // Assert
            methodRemoveUsersParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveUsers) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_RemoveUsers_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveUsers, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddIndividual) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Member_AddIndividual_Method_Call_Internally(Type[] types)
        {
            var methodAddIndividualParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddIndividual, methodAddIndividualParametersTypes);
        }

        #endregion

        #region Method Call : (AddIndividual) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_AddIndividual_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddIndividual);
            var ind = this.CreateType<OnyxIndividual>();

            // Act
            Action executeAction = () => _memberInstance.AddIndividual(ind);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (AddIndividual) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_AddIndividual_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddIndividual);
            var ind = this.CreateType<OnyxIndividual>();
            var methodAddIndividualParametersTypes = new Type[] { typeof(OnyxIndividual) };
            object[] parametersOfAddIndividual = { ind };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddIndividual, methodAddIndividualParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_memberInstanceFixture, parametersOfAddIndividual);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddIndividual.ShouldNotBeNull();
            parametersOfAddIndividual.Length.ShouldBe(1);
            methodAddIndividualParametersTypes.Length.ShouldBe(1);
            methodAddIndividualParametersTypes.Length.ShouldBe(parametersOfAddIndividual.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddIndividual) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_AddIndividual_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddIndividual);
            var ind = this.CreateType<OnyxIndividual>();
            var methodAddIndividualParametersTypes = new Type[] { typeof(OnyxIndividual) };
            object[] parametersOfAddIndividual = { ind };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddIndividual, parametersOfAddIndividual, methodAddIndividualParametersTypes);

            // Assert
            parametersOfAddIndividual.ShouldNotBeNull();
            parametersOfAddIndividual.Length.ShouldBe(1);
            methodAddIndividualParametersTypes.Length.ShouldBe(1);
            methodAddIndividualParametersTypes.Length.ShouldBe(parametersOfAddIndividual.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddIndividual) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_AddIndividual_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddIndividual);
            var currentMethodInfo = this.GetMethodInfo(MethodAddIndividual, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddIndividual) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_AddIndividual_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddIndividual);
            var methodAddIndividualParametersTypes = new Type[] { typeof(OnyxIndividual) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddIndividual, methodAddIndividualParametersTypes);

            // Assert
            methodAddIndividualParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddIndividual) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_AddIndividual_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddIndividual);
            var currentMethodInfo = this.GetMethodInfo(MethodAddIndividual, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddInternalUser) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Member_AddInternalUser_Method_Call_Internally(Type[] types)
        {
            var methodAddInternalUserParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddInternalUser, methodAddInternalUserParametersTypes);
        }

        #endregion

        #region Method Call : (AddInternalUser) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_AddInternalUser_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddInternalUser);
            var user = this.CreateType<OnyxUser>();

            // Act
            Action executeAction = () => _memberInstance.AddInternalUser(user);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (AddInternalUser) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_AddInternalUser_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddInternalUser);
            var user = this.CreateType<OnyxUser>();
            var methodAddInternalUserParametersTypes = new Type[] { typeof(OnyxUser) };
            object[] parametersOfAddInternalUser = { user };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddInternalUser, methodAddInternalUserParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_memberInstanceFixture, parametersOfAddInternalUser);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddInternalUser.ShouldNotBeNull();
            parametersOfAddInternalUser.Length.ShouldBe(1);
            methodAddInternalUserParametersTypes.Length.ShouldBe(1);
            methodAddInternalUserParametersTypes.Length.ShouldBe(parametersOfAddInternalUser.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddInternalUser) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_AddInternalUser_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddInternalUser);
            var user = this.CreateType<OnyxUser>();
            var methodAddInternalUserParametersTypes = new Type[] { typeof(OnyxUser) };
            object[] parametersOfAddInternalUser = { user };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddInternalUser, parametersOfAddInternalUser, methodAddInternalUserParametersTypes);

            // Assert
            parametersOfAddInternalUser.ShouldNotBeNull();
            parametersOfAddInternalUser.Length.ShouldBe(1);
            methodAddInternalUserParametersTypes.Length.ShouldBe(1);
            methodAddInternalUserParametersTypes.Length.ShouldBe(parametersOfAddInternalUser.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddInternalUser) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_AddInternalUser_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddInternalUser);
            var currentMethodInfo = this.GetMethodInfo(MethodAddInternalUser, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddInternalUser) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_AddInternalUser_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddInternalUser);
            var methodAddInternalUserParametersTypes = new Type[] { typeof(OnyxUser) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddInternalUser, methodAddInternalUserParametersTypes);

            // Assert
            methodAddInternalUserParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddInternalUser) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Member_AddInternalUser_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddInternalUser);
            var currentMethodInfo = this.GetMethodInfo(MethodAddInternalUser, 0);

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