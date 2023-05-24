using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.GenericListControl" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class GenericListControlDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="GenericListControlNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddContactControl" /> to
        ///     create a non-public type.
        /// </summary>
        public GenericListControlDesignerTest() : base(publicType: typeof(AddContactControl), classNameWithNamespace: GenericListControlNonPublicTypeName)
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

        private Type _genericListControlInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string GenericListControlNonPublicTypeName = "OnyxOutlookAddin.GenericListControl";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _genericListControlInstance;
        private object _genericListControlInstanceFixture;

        #region General Initializer : Class (GenericListControl) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="GenericListControl" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _genericListControlInstanceFixture = this.CreateNonPublicType(GenericListControlNonPublicTypeName);
            _genericListControlInstance = _genericListControlInstanceFixture;
            CurrentInstance = _genericListControlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (GenericListControl) Initializer

        #region Methods

        private const string MethodInitializeComponent = "InitializeComponent";

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (GenericListControl)

        #region General Initializer : Class (GenericListControl) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="GenericListControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitializeComponent, 0)]
        [Category("AUT Explore")]
        public void AUT_GenericListControlDesigner_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (GenericListControl) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="GenericListControl" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GenericListControlDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (GenericListControl) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="GenericListControl" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GenericListControlDesigner_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (GenericListControl) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="GenericListControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [Category("AUT Fields")]
        public void AUT_GenericListControlDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (GenericListControl) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="GenericListControl" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GenericListControlDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
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