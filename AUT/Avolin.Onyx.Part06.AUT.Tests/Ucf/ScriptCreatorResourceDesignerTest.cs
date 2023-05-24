using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Ucf;

namespace Avolin.Onyx.Part06.AUT.Tests.Ucf
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.ScriptCreatorResource" />)
    ///     and namespace <see cref="Onyx.Ucf"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptCreatorResourceDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ScriptCreatorResourceNonPublicTypeName" />) using
        ///     Using a public type <see cref="Constants" /> to
        ///     create a non-public type.
        /// </summary>
        public ScriptCreatorResourceDesignerTest() : base(publicType: typeof(Constants), classNameWithNamespace: ScriptCreatorResourceNonPublicTypeName)
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

        private Type _scriptCreatorResourceInstanceType;
        
        private const string ScriptCreatorResourceNonPublicTypeName = "Onyx.Ucf.ScriptCreatorResource";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _scriptCreatorResourceInstance;
        private object _scriptCreatorResourceInstanceFixture;

        #region General Initializer : Class (ScriptCreatorResource) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="ScriptCreatorResource" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptCreatorResourceInstanceFixture = this.CreateNonPublicType(ScriptCreatorResourceNonPublicTypeName);
            _scriptCreatorResourceInstance = _scriptCreatorResourceInstanceFixture;
            CurrentInstance = _scriptCreatorResourceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptCreatorResource) Initializer

        #region Properties

        private const string PropertyResourceManager = "ResourceManager";
        private const string PropertyCulture = "Culture";
        private const string PropertyactionArgumentEventArgument1 = "actionArgumentEventArgument1";
        private const string PropertyactionArgumentEventArgument2 = "actionArgumentEventArgument2";
        private const string PropertyactionArgumentPageVariable = "actionArgumentPageVariable";
        private const string PropertyactionRemoved = "actionRemoved";
        private const string PropertyconditionAnd = "conditionAnd";
        private const string PropertyconditionClose = "conditionClose";
        private const string PropertyconditionGroupClose = "conditionGroupClose";
        private const string PropertyconditionGroupOpen = "conditionGroupOpen";
        private const string PropertyconditionOpen = "conditionOpen";
        private const string PropertyconditionOr = "conditionOr";
        private const string PropertydeltaActionAddStatementAsEventChild = "deltaActionAddStatementAsEventChild";
        private const string PropertydeltaActionAddStatementRelative = "deltaActionAddStatementRelative";
        private const string PropertydeltaActionDisableStatement = "deltaActionDisableStatement";
        private const string PropertydeltaActionMoveStatementRelative = "deltaActionMoveStatementRelative";
        private const string PropertydeltaActionMoveStatementToEvent = "deltaActionMoveStatementToEvent";
        private const string PropertydeltaActionRemoveStatement = "deltaActionRemoveStatement";
        private const string PropertydeltaActionRemoveStatementsByFrameworkObject = "deltaActionRemoveStatementsByFrameworkObject";
        private const string PropertydeltaActionReplaceStatement = "deltaActionReplaceStatement";
        private const string PropertyeventHandlerImplementerFunction = "eventHandlerImplementerFunction";
        private const string PropertyframeworkObjectAction = "frameworkObjectAction";
        private const string PropertyframeworkObjectActionDefaultValue = "frameworkObjectActionDefaultValue";
        private const string PropertyframeworkObjectFunctionBase = "frameworkObjectFunctionBase";
        private const string PropertyframeworkObjectFunctionBaseGetParent = "frameworkObjectFunctionBaseGetParent";
        private const string PropertyframeworkObjectFunctionBaseGetParentNull = "frameworkObjectFunctionBaseGetParentNull";
        private const string PropertypageAreToolboxControlsDirtyFunction = "pageAreToolboxControlsDirtyFunction";
        private const string PropertypageScriptAfterHtml = "pageScriptAfterHtml";
        private const string PropertypageScriptBeforeHtml = "pageScriptBeforeHtml";
        private const string PropertypageScriptHelpers = "pageScriptHelpers";
        private const string PropertypageVariableInitialize = "pageVariableInitialize";
        private const string PropertysafeModeAspComment = "safeModeAspComment";
        private const string PropertystatementActionCall = "statementActionCall";
        private const string PropertystatementActionForceStop = "statementActionForceStop";
        private const string PropertystatementActionPostScript = "statementActionPostScript";
        private const string PropertystatementActionSaveResult = "statementActionSaveResult";
        private const string PropertystatementBase = "statementBase";
        private const string PropertystatementBaseNoConditions = "statementBaseNoConditions";
        private const string PropertytoolboxDirtyTest = "toolboxDirtyTest";
        private const string PropertyuiContainerPropertiesLabel = "uiContainerPropertiesLabel";
        private const string PropertyuiContainerPropertiesProcess = "uiContainerPropertiesProcess";
        private const string PropertyuiContainerPropertiesRenderControl = "uiContainerPropertiesRenderControl";
        private const string PropertyuiContainerPropertiesSetDomainData = "uiContainerPropertiesSetDomainData";
        private const string PropertyuiContainerPropertiesSetTabIndexes = "uiContainerPropertiesSetTabIndexes";

        #endregion

        #region Fields

        private const string FieldresourceMan = "resourceMan";
        private const string FieldresourceCulture = "resourceCulture";

        #endregion

        #endregion

        #endregion

        #endregion
    }
}