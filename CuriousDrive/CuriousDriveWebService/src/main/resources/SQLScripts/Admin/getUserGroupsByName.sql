SELECT USER_GROUP_ID,GROUP_NAME,GROUP_DESCRIPTION,GROUP_STATUS_VALUE,CV.DESCRIPTION
FROM tran_user_group UG
INNER JOIN sys_code_value CV ON CV.CODE_ID = UG.GROUP_STATUS_ID AND CV.CODE_VALUE = UG.GROUP_STATUS_VALUE
WHERE UG.GROUP_NAME LIKE ?