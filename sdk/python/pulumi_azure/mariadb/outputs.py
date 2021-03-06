# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables

__all__ = [
    'ServerStorageProfile',
    'GetMariaDbServerStorageProfileResult',
]

@pulumi.output_type
class ServerStorageProfile(dict):
    def __init__(__self__, *,
                 auto_grow: Optional[str] = None,
                 backup_retention_days: Optional[float] = None,
                 geo_redundant_backup: Optional[str] = None,
                 storage_mb: Optional[float] = None):
        """
        :param float backup_retention_days: Backup retention days for the server, supported values are between `7` and `35` days.
        :param float storage_mb: Max storage allowed for a server. Possible values are between `5120` MB (5GB) and `1024000`MB (1TB) for the Basic SKU and between `5120` MB (5GB) and `4096000` MB (4TB) for General Purpose/Memory Optimized SKUs. For more information see the [product documentation](https://docs.microsoft.com/en-us/rest/api/mariadb/servers/create#storageprofile).
        """
        if auto_grow is not None:
            pulumi.set(__self__, "auto_grow", auto_grow)
        if backup_retention_days is not None:
            pulumi.set(__self__, "backup_retention_days", backup_retention_days)
        if geo_redundant_backup is not None:
            pulumi.set(__self__, "geo_redundant_backup", geo_redundant_backup)
        if storage_mb is not None:
            pulumi.set(__self__, "storage_mb", storage_mb)

    @property
    @pulumi.getter(name="autoGrow")
    def auto_grow(self) -> Optional[str]:
        return pulumi.get(self, "auto_grow")

    @property
    @pulumi.getter(name="backupRetentionDays")
    def backup_retention_days(self) -> Optional[float]:
        """
        Backup retention days for the server, supported values are between `7` and `35` days.
        """
        return pulumi.get(self, "backup_retention_days")

    @property
    @pulumi.getter(name="geoRedundantBackup")
    def geo_redundant_backup(self) -> Optional[str]:
        return pulumi.get(self, "geo_redundant_backup")

    @property
    @pulumi.getter(name="storageMb")
    def storage_mb(self) -> Optional[float]:
        """
        Max storage allowed for a server. Possible values are between `5120` MB (5GB) and `1024000`MB (1TB) for the Basic SKU and between `5120` MB (5GB) and `4096000` MB (4TB) for General Purpose/Memory Optimized SKUs. For more information see the [product documentation](https://docs.microsoft.com/en-us/rest/api/mariadb/servers/create#storageprofile).
        """
        return pulumi.get(self, "storage_mb")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class GetMariaDbServerStorageProfileResult(dict):
    def __init__(__self__, *,
                 auto_grow: str,
                 backup_retention_days: float,
                 geo_redundant_backup: str,
                 storage_mb: float):
        """
        :param str auto_grow: Whether autogrow is enabled or disabled for the storage.
        :param float backup_retention_days: Backup retention days for the server.
        :param str geo_redundant_backup: Whether Geo-redundant is enabled or not for server backup.
        :param float storage_mb: The max storage allowed for a server.
        """
        pulumi.set(__self__, "auto_grow", auto_grow)
        pulumi.set(__self__, "backup_retention_days", backup_retention_days)
        pulumi.set(__self__, "geo_redundant_backup", geo_redundant_backup)
        pulumi.set(__self__, "storage_mb", storage_mb)

    @property
    @pulumi.getter(name="autoGrow")
    def auto_grow(self) -> str:
        """
        Whether autogrow is enabled or disabled for the storage.
        """
        return pulumi.get(self, "auto_grow")

    @property
    @pulumi.getter(name="backupRetentionDays")
    def backup_retention_days(self) -> float:
        """
        Backup retention days for the server.
        """
        return pulumi.get(self, "backup_retention_days")

    @property
    @pulumi.getter(name="geoRedundantBackup")
    def geo_redundant_backup(self) -> str:
        """
        Whether Geo-redundant is enabled or not for server backup.
        """
        return pulumi.get(self, "geo_redundant_backup")

    @property
    @pulumi.getter(name="storageMb")
    def storage_mb(self) -> float:
        """
        The max storage allowed for a server.
        """
        return pulumi.get(self, "storage_mb")


