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

Partial Public Class tblServices
    Public Property ServiceID As Integer
    Public Property ServiceUUID As Guid
    Public Property ServCode As String
    Public Property ServName As String
    Public Property ServType As String
    Public Property ServLevel As String
    Public Property ServPrice As Decimal
    Public Property ServCareType As String
    Public Property ServFrequency As Nullable(Of Short)
    Public Property ServPatCat As Byte
    Public Property ValidityFrom As Nullable(Of Date)
    Public Property ValidityTo As Nullable(Of Date)
    Public Property LegacyID As Nullable(Of Integer)
    Public Property AuditUserID As Nullable(Of Integer)
    Public Property RowID As Byte()
    Public Property ServCategory As String

    Public Overridable Property tblClaimServices As ICollection(Of tblClaimServices) = New HashSet(Of tblClaimServices)
    Public Overridable Property tblPLServicesDetail As ICollection(Of tblPLServicesDetail) = New HashSet(Of tblPLServicesDetail)
    Public Overridable Property tblProductServices As ICollection(Of tblProductServices) = New HashSet(Of tblProductServices)

End Class
