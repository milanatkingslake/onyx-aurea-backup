using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.CustomContextMenu" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CustomContextMenuTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="CustomContextMenuNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddContactControl" /> to
        ///     create a non-public type.
        /// </summary>
        public CustomContextMenuTest() : base(publicType: typeof(AddContactControl), classNameWithNamespace: CustomContextMenuNonPublicTypeName)
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

        private Type _customContextMenuInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string CustomContextMenuNonPublicTypeName = "OnyxOutlookAddin.CustomContextMenu";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _customContextMenuInstance;
        private object _customContextMenuInstanceFixture;

        #region General Initializer : Class (CustomContextMenu) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="CustomContextMenu" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _customContextMenuInstanceFixture = this.CreateNonPublicType(CustomContextMenuNonPublicTypeName);
            _customContextMenuInstance = _customContextMenuInstanceFixture;
            CurrentInstance = _customContextMenuInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CustomContextMenu) Initializer

        #region Methods

        private const string MethodcreateContextMenu = "createContextMenu";
        private const string MethodcontextMenuStripTextBoxOpening = "contextMenuStripTextBoxOpening";
        private const string MethodcopyLabelClick = "copyLabelClick";
        private const string MethodcopyClick = "copyClick";
        private const string MethodselectAllClick = "selectAllClick";

        #endregion

        #region Fields

        private const string FieldmenuStrip = "menuStrip";
        private const string FieldtextBox = "textBox";
        private const string Fieldlabel = "label";
        private const string FieldisLabel = "isLabel";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (CustomContextMenu)

        #region General Initializer : Class (CustomContextMenu) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CustomContextMenu" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodcreateContextMenu, 0)]
        [TestCase(MethodcontextMenuStripTextBoxOpening, 0)]
        [TestCase(MethodcopyLabelClick, 0)]
        [TestCase(MethodcopyClick, 0)]
        [TestCase(MethodselectAllClick, 0)]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_CustomContextMenu_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CustomContextMenu) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CustomContextMenu" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_CustomContextMenu_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (CustomContextMenu) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CustomContextMenu" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldmenuStrip)]
        [TestCase(FieldtextBox)]
        [TestCase(Fieldlabel)]
        [TestCase(FieldisLabel)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_CustomContextMenu_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (CustomContextMenu) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CustomContextMenu" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_CustomContextMenu_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CustomContextMenu) instance created

        /// <summary>
        ///     Class (<see cref="CustomContextMenu" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_CustomContextMenu_Is_Created_Test()
        {
            // Assert
            _customContextMenuInstance.ShouldNotBeNull();
            _customContextMenuInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (CustomContextMenu) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="CustomContextMenu" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_CustomContextMenu_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (CustomContextMenu) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="CustomContextMenu" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_CustomContextMenu_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (CustomContextMenu) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="CustomContextMenu" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_CustomContextMenu_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodCustomContextMenuParametersTypes = new Type[] { typeof(TextBox) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodCustomContextMenuParametersTypes);
        }

        #endregion

        #region General Constructor : Class (CustomContextMenu) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="CustomContextMenu" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_CustomContextMenu_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodCustomContextMenuParametersTypes = new Type[] { typeof(Label) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodCustomContextMenuParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}