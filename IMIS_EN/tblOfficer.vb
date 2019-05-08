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

Partial Public Class tblOfficer
    Public Property OfficerID As Integer
    Public Property Code As String
    Public Property LastName As String
    Public Property OtherNames As String
    Public Property DOB As Nullable(Of Date)
    Public Property Phone As String
    Public Property LocationId As Nullable(Of Integer)
    Public Property OfficerIDSubst As Nullable(Of Integer)
    Public Property WorksTo As Nullable(Of Date)
    Public Property VEOCode As String
    Public Property VEOLastName As String
    Public Property VEOOtherNames As String
    Public Property VEODOB As Nullable(Of Date)
    Public Property VEOPhone As String
    Public Property ValidityFrom As Date
    Public Property ValidityTo As Nullable(Of Date)
    Public Property LegacyID As Nullable(Of Integer)
    Public Property AuditUserID As Integer
    Public Property RowID As Byte()
    Public Property EmailId As String
    Public Property PhoneCommunication As Nullable(Of Boolean)
    Public Property PermanentAddress As String

    Public Overridable Property tblLocations As tblLocations
    Public Overridable Property tblOfficer1 As ICollection(Of tblOfficer) = New HashSet(Of tblOfficer)
    Public Overridable Property tblOfficer2 As tblOfficer
    Public Overridable Property tblOfficerVillages As ICollection(Of tblOfficerVillages) = New HashSet(Of tblOfficerVillages)
    Public Overridable Property tblPolicy As ICollection(Of tblPolicy) = New HashSet(Of tblPolicy)
    Public Overridable Property tblPolicyRenewals As ICollection(Of tblPolicyRenewals) = New HashSet(Of tblPolicyRenewals)

End Class
