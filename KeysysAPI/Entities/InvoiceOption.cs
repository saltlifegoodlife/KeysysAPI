using System;
using System.Collections.Generic;

namespace KeysysAPI.Entities;

public partial class InvoiceOption
{
    public string? MessageId { get; set; }

    public string? CorrelationId { get; set; }

    public string? SoftwareVersionNumber { get; set; }

    public string? StatusCode { get; set; }

    public int? ResultCode { get; set; }

    public int? Ns4AcknowledgementCode { get; set; }

    public string? Ns4AcknowledgementMessage { get; set; }

    public string? Ns4TransactionId { get; set; }

    public int? Ns4Servicer { get; set; }

    public string? Ns4Company { get; set; }

    public long? Ns4LoanNumber { get; set; }

    public long? Ns4BillingEntity { get; set; }

    public int? Ns4BillingCode { get; set; }

    public string? Ns4BillingDateTime { get; set; }

    public string? Ns5ContactInformation { get; set; }

    public string? Ns5CorrelationId { get; set; }

    public string? Ns3CategoryDescription { get; set; }

    public int? Ns3CategoryId { get; set; }

    public int? Ns3InvoiceTypeCode { get; set; }

    public string? Ns3InvoiceTypeDescription { get; set; }

    public string? Ns3SubCategoryDescription { get; set; }

    public int? Ns3SubCategoryId { get; set; }
}
