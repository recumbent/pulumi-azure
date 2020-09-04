# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables

__all__ = [
    'CacheNfsTargetNamespaceJunctionArgs',
]

@pulumi.input_type
class CacheNfsTargetNamespaceJunctionArgs:
    def __init__(__self__, *,
                 namespace_path: pulumi.Input[str],
                 nfs_export: pulumi.Input[str],
                 target_path: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] namespace_path: The client-facing file path of this NFS target within the HPC Cache NFS Target.
        :param pulumi.Input[str] nfs_export: The NFS export of this NFS target within the HPC Cache NFS Target.
        :param pulumi.Input[str] target_path: The relative subdirectory path from the `nfs_export` to map to the `namespace_path`. Defaults to `""`, in which case the whole `nfs_export` is exported.
        """
        pulumi.set(__self__, "namespace_path", namespace_path)
        pulumi.set(__self__, "nfs_export", nfs_export)
        if target_path is not None:
            pulumi.set(__self__, "target_path", target_path)

    @property
    @pulumi.getter(name="namespacePath")
    def namespace_path(self) -> pulumi.Input[str]:
        """
        The client-facing file path of this NFS target within the HPC Cache NFS Target.
        """
        return pulumi.get(self, "namespace_path")

    @namespace_path.setter
    def namespace_path(self, value: pulumi.Input[str]):
        pulumi.set(self, "namespace_path", value)

    @property
    @pulumi.getter(name="nfsExport")
    def nfs_export(self) -> pulumi.Input[str]:
        """
        The NFS export of this NFS target within the HPC Cache NFS Target.
        """
        return pulumi.get(self, "nfs_export")

    @nfs_export.setter
    def nfs_export(self, value: pulumi.Input[str]):
        pulumi.set(self, "nfs_export", value)

    @property
    @pulumi.getter(name="targetPath")
    def target_path(self) -> Optional[pulumi.Input[str]]:
        """
        The relative subdirectory path from the `nfs_export` to map to the `namespace_path`. Defaults to `""`, in which case the whole `nfs_export` is exported.
        """
        return pulumi.get(self, "target_path")

    @target_path.setter
    def target_path(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "target_path", value)

