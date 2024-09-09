// MigraDoc - Creating Documents on the Fly
// See the LICENSE file in the solution root for more information.


namespace MigraDoc.DocumentObjectModel
{
    /// <summary>
    /// MigraDoc DOM messages.
    /// String resources of MigraDoc.DocumentObjectModel. Provides all localized text strings
    /// for this assembly.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    // ReSharper disable once IdentifierTypo
    static class MdDomMsgs
    {
        #region General Messages

        public static string StyleExpected(Type wrongType)
            => $"The value must be of type 'Style', but it is of type '{wrongType.Name}'.";

        public static string BaseStyleRequired
            => "Base style name must be defined.";

        public static string EmptyBaseStyle
            => "Attempt to set empty base style is invalid.";

        public static string InvalidFieldFormat(string format)
            => $"'{format}' is not a valid numeric field format.";

        public static string InvalidInfoFieldName(string name)
            => $"Property 'Name' of 'InfoField' has invalid value '{name}'.";

        public static string UndefinedBaseStyle(string style)
            => $"The base style of style '{style}' is undefined.";

        public static string InvalidValueName(string name)
            => $"Invalid value name: '{name}'.";

        public static string InvalidUnitValue(string unitValue)
            => $"String '{unitValue}' is not a valid value for structure 'Unit'.";

        public static string InvalidUnitType(string unitType)
            => $"'{unitType}' is an unknown unit type.";

        public static string InvalidEnumValue<T>(T value) where T : Enum
            => $"The value '{value:X}' is not valid for enum type '{typeof(T)}'.";

        public static string InvalidEnumForLeftPosition
            => "ShapePosition must be 'Left', 'Center', or 'Right'.";

        public static string InvalidEnumForTopPosition
            => "ShapePosition must be 'Top', 'Center', or 'Bottom'.";

        public static string InvalidColorString(string colorString)
            => $"Color could not be parsed from string '{colorString}'.";

        public static string InvalidFontSize(double value)
            => $"The font size '{value}' is out of range.";

        public static string InsertNullNotAllowed()
            => "Insert null not allowed.";

        public static string ParentAlreadySet(DocumentObject value, DocumentObject docObject)
            => $"Value of type '{value.GetType()}' must be cloned before setting into '{docObject.GetType()}'.";

        public static string MissingObligatoryProperty(string propertyName, string className)
            => $"Obligatory property '{propertyName}' not set in '{className}'.";

        public static string InvalidDocumentObjectType
            => "The given document object is not valid in this context.";

        #endregion

        #region DdlReader Messages

        public static string SymbolExpected(string expected, string token)
            => $"'{expected}' expected, found '{token}'.";

        //public static string SymbolsExpected
        //    => "One of the following symbols {x} is expected.";

        //public static string OperatorExpected
        //    => "Syntax error: Operator '{x}' is expected.";

        //public static string KeyWordExpected
        //    => "'{y}' - '{x}' expected.";

        public static string EndOfFileExpected
            => "End of file expected.";
        public static string UnexpectedEndOfFile
            => "Unexpected end of file.";

        public static string StyleNameExpected(string name)
            => $"Invalid style name '{name}'.";

        public static string UnexpectedSymbol(string token)
            => $"Unexpected symbol '{token}'.";

        public static string IdentifierExpected(string token)
            => $"Identifier expected: '{token}'.";

        public static string BoolValueExpected(string token)
            => $"Bool value expected: '{token}'.";

        public static string RealValueExpected(string token)
            => $"Real value expected: '{token}'.";

        public static string IntegerValueExpected(string token)
            => $"Integer value expected: '{token}'.";

        public static string StringValueExpected(string token)
            => $"String value expected: '{token}'.";

        public static string NullValueExpected(string token)
            => $"Null value expected: '{token}'.";

        public static string NumberValueExpected(string token)
            => $"Number value expected: '{token}'.";

        public static string InvalidEnum(string token, string typeName)
            => $"'{token}' is not a valid value for type '{typeName}'.";

        public static string InvalidType(string typeName, string valueName)
            => $"Variable type '{typeName}' not supported by '{valueName}'.";

        public static string InvalidAssignment(string name)
            => $"Invalid assignment to '{name}'.";

        //public static string InvalidValueName => "Invalid value name: '{x}'.");

        public static string InvalidRange(string range)
            => $"Invalid range: '{range}'.";

        public static string InvalidColor(string token)
            => $"Invalid color: '{token}'.";

        public static string InvalidFieldType(string token)
            => $"Invalid field type: '{token}'.";

        public static string InvalidValueForOperation(string value, string token)
            => $"Operation '{token}' is not valid for value '{value}'.";

        public static string InvalidSymbolType(string token)
            => $"Symbol not valid '{token}'.";

        public static string MissingBraceLeft(string token)
            => $"Missing left brace after '{token}'.";

        public static string MissingBraceRight(string token)
            => $"Missing right brace after '{token}'.";

        public static string MissingBracketLeft(string token)
            => $"Missing left bracket after '{token}'.";

        public static string MissingBracketRight(string token)
            => $"Missing right bracket after '{token}'.";

        public static string MissingParenLeft(string token)
            => $"Missing left parenthesis after '{token}'.";

        public static string MissingParenRight(string token)
            => $"Missing right parenthesis after '{token}'.";

        public static string MissingComma
            => "Missing comma.";

        public static string SymbolNotAllowed(string token)
            => $"Symbol '{token}' is not allowed in this context.";

        public static string SymbolIsNotAnObject(string token)
            => $"Symbol '{token}' is not an object.";

        public static string UnknownChartType(string name)
            => $"Unknown chart type: '{name}'.";

        public static string NoAccess(string name)
            => $"Access denied: '{name}' for internal use only.";

        public static string NewlineInString
            => "Newline in string not allowed.";

        public static string EscapeSequenceNotAllowed(string token)
            => $"Invalid escape sequence '{token}'.";

        public static string NullAssignmentNotSupported(string name)
            => $"Assigning 'null' to '{name}' not allowed.";

        public static string OutOfRange(string range)
            => $"Valid range only within '{range}'.";

        public static string UseOfUndefinedBaseStyle(string styleName)
            => $"Use of undefined base style '{styleName}'.";

        public static string UseOfUndefinedStyle(string styleName)
            => $"Use of undefined style '{styleName}'.";

        #endregion
    }
}
