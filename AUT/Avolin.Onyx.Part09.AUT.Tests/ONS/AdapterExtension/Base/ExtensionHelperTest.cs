using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.ONS.AdapterExtension.Base;
using Shouldly;

namespace Avolin.Onyx.Part09.AUT.Tests.ONS.AdapterExtension.Base
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.ONS.AdapterExtension.Base.ExtensionHelper" />)
    ///     and namespace <see cref="Onyx.ONS.AdapterExtension.Base"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ExtensionHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ExtensionHelperNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddressFilter" /> to
        ///     create a non-public type.
        /// </summary>
        public ExtensionHelperTest() : base(publicType: typeof(AddressFilter), classNameWithNamespace: ExtensionHelperNonPublicTypeName)
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

        private Type _extensionHelperInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string ExtensionHelperNonPublicTypeName = "Onyx.ONS.AdapterExtension.Base.ExtensionHelper";

        #region General Initializer : Class (ExtensionHelper) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="ExtensionHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ExtensionHelper) Initializer

        #region Methods

        private const string MethodRemoveCData = "RemoveCData";
        private const string MethodRemoveCollections = "RemoveCollections";
        private const string MethodUpdateAction = "UpdateAction";
        private const string MethodFilterInvalidEvents = "FilterInvalidEvents";
        private const string MethodFilterEmptyEvents = "FilterEmptyEvents";
        private const string MethodIgnoreElement = "IgnoreElement";
        private const string MethodIgnoreElementWithCondition = "IgnoreElementWithCondition";
        private const string MethodIsCollection = "IsCollection";
        private const string MethodSetPrimaryKeyName = "SetPrimaryKeyName";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";
        private const string FieldOldData = "OldData";
        private const string FieldNewData = "NewData";
        private const string FieldEmbeddedXml = "EmbeddedXml";
        private const string FieldActionName = "ActionName";
        private const string FieldNewValueSql = "NewValueSql";
        private const string FieldOldValueSql = "OldValueSql";
        private const string FieldNewValueLbo = "NewValueLbo";
        private const string FieldOldValueLbo = "OldValueLbo";
        private const string FieldIgnore = "Ignore";
        private const string FieldChangeType = "ChangeType";
        private const string FieldIgnoreWithCondition = "IgnoreWithCondition";
        private const string FieldAppData = "AppData";
        private const string FieldactionNodeName = "actionNodeName";
        private const string FieldinterfaceNodeName = "interfaceNodeName";
        private const string FieldPrimaryKey = "PrimaryKey";
        private const string FieldNewValue = "NewValue";
        private const string FieldOldValue = "OldValue";
        private const string FieldCollectionName = "CollectionName";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (ExtensionHelper)

        #region General Initializer : Class (ExtensionHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ExtensionHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodRemoveCData, 0)]
        [TestCase(MethodRemoveCollections, 0)]
        [TestCase(MethodUpdateAction, 0)]
        [TestCase(MethodFilterInvalidEvents, 0)]
        [TestCase(MethodFilterEmptyEvents, 0)]
        [TestCase(MethodIgnoreElement, 0)]
        [TestCase(MethodIgnoreElementWithCondition, 0)]
        [TestCase(MethodIsCollection, 0)]
        [TestCase(MethodSetPrimaryKeyName, 0)]
        [Category("AUT Explore")]
        public void AUT_ExtensionHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ExtensionHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ExtensionHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ExtensionHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (ExtensionHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ExtensionHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [TestCase(FieldOldData)]
        [TestCase(FieldNewData)]
        [TestCase(FieldEmbeddedXml)]
        [TestCase(FieldActionName)]
        [TestCase(FieldNewValueSql)]
        [TestCase(FieldOldValueSql)]
        [TestCase(FieldNewValueLbo)]
        [TestCase(FieldOldValueLbo)]
        [TestCase(FieldIgnore)]
        [TestCase(FieldChangeType)]
        [TestCase(FieldIgnoreWithCondition)]
        [TestCase(FieldAppData)]
        [TestCase(FieldactionNodeName)]
        [TestCase(FieldinterfaceNodeName)]
        [TestCase(FieldPrimaryKey)]
        [TestCase(FieldNewValue)]
        [TestCase(FieldOldValue)]
        [TestCase(FieldCollectionName)]
        [Category("AUT Fields")]
        public void AUT_ExtensionHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ExtensionHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ExtensionHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ExtensionHelper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}