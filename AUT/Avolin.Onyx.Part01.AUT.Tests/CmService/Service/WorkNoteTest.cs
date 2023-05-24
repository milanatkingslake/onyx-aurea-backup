using System;
using System.Diagnostics.CodeAnalysis;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.WorkNote" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\WorkNote.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class WorkNoteTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="WorkNoteNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public WorkNoteTest() : base(publicType: typeof(Common), classNameWithNamespace: WorkNoteNonPublicTypeName)
        { }

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

        private Type _workNoteInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string WorkNoteNonPublicTypeName = "CmService.Service.WorkNote";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _workNoteInstance;
        private object _workNoteInstanceFixture;

        #region General Initializer : Class (WorkNote) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="WorkNote" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _workNoteInstanceFixture = this.CreateNonPublicType(WorkNoteNonPublicTypeName);
            _workNoteInstance = _workNoteInstanceFixture;
            CurrentInstance = _workNoteInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (WorkNote) Initializer

        #region Methods

        private const string MethodGetWorkNoteFieldMetaData = "GetWorkNoteFieldMetaData";
        private const string MethodSave = "Save";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (WorkNote)

        #region General Initializer : Class (WorkNote) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="WorkNote" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetWorkNoteFieldMetaData, 0)]
        [TestCase(MethodSave, 0)]
        [Category("AUT Explore")]
        public void AUT_WorkNote_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (WorkNote) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="WorkNote" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_WorkNote_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #endregion
    }
}