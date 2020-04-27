// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package appservice

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Use this data source to access information about an App Service Certificate.
func LookupCertificate(ctx *pulumi.Context, args *LookupCertificateArgs, opts ...pulumi.InvokeOption) (*LookupCertificateResult, error) {
	var rv LookupCertificateResult
	err := ctx.Invoke("azure:appservice/getCertificate:getCertificate", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getCertificate.
type LookupCertificateArgs struct {
	// Specifies the name of the certificate.
	Name string `pulumi:"name"`
	// The name of the resource group in which to create the certificate.
	ResourceGroupName string            `pulumi:"resourceGroupName"`
	Tags              map[string]string `pulumi:"tags"`
}

// A collection of values returned by getCertificate.
type LookupCertificateResult struct {
	// The expiration date for the certificate.
	ExpirationDate string `pulumi:"expirationDate"`
	// The friendly name of the certificate.
	FriendlyName string `pulumi:"friendlyName"`
	// List of host names the certificate applies to.
	HostNames []string `pulumi:"hostNames"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The issue date for the certificate.
	IssueDate string `pulumi:"issueDate"`
	// The name of the certificate issuer.
	Issuer            string `pulumi:"issuer"`
	Location          string `pulumi:"location"`
	Name              string `pulumi:"name"`
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The subject name of the certificate.
	SubjectName string            `pulumi:"subjectName"`
	Tags        map[string]string `pulumi:"tags"`
	// The thumbprint for the certificate.
	Thumbprint string `pulumi:"thumbprint"`
}
