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

Partial Public Class tblPremium
    Public Property PremiumId As Integer
    Public Property PolicyID As Integer
    Public Property PayerID As Nullable(Of Integer)
    Public Property Amount As Decimal
    Public Property Receipt As String
    Public Property PayDate As Date
    Public Property PayType As String
    Public Property ValidityFrom As Date
    Public Property ValidityTo As Nullable(Of Date)
    Public Property LegacyID As Nullable(Of Integer)
    Public Property AuditUserID As Integer
    Public Property RowID As Byte()
    Public Property isPhotoFee As Nullable(Of Boolean)
    Public Property isOffline As Nullable(Of Boolean)
    Public Property ReportingId As Nullable(Of Integer)

    Public Overridable Property tblPayer As tblPayer
    Public Overridable Property tblPolicy As tblPolicy

End Class
