'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class tblExtracts
    Public Property ExtractID As Integer
    Public Property ExtractUUID As Guid
    Public Property ExtractDirection As Byte
    Public Property ExtractType As Byte
    Public Property ExtractSequence As Integer
    Public Property ExtractDate As Date
    Public Property ExtractFileName As String
    Public Property ExtractFolder As String
    Public Property LocationId As Integer
    Public Property HFID As Nullable(Of Integer)
    Public Property AppVersionBackend As Decimal
    Public Property ValidityFrom As Date
    Public Property ValidityTo As Nullable(Of Date)
    Public Property LegacyID As Nullable(Of Integer)
    Public Property AuditUserID As Integer
    Public Property RowID As Nullable(Of Long)

End Class