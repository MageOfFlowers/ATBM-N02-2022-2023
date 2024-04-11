--TK
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'100', label_value=>'TK::');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'110', label_value=>'TK:HTTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'120', label_value=>'TK:CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'130', label_value=>'TK:KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'140', label_value=>'TK:CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'150', label_value=>'TK:TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'160', label_value=>'TK:MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'101', label_value=>'TK::CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'102', label_value=>'TK::CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'103', label_value=>'TK::CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'111', label_value=>'TK:HTTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'121', label_value=>'TK:CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'131', label_value=>'TK:KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'141', label_value=>'TK:CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'151', label_value=>'TK:TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'161', label_value=>'TK:MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'112', label_value=>'TK:HTTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'122', label_value=>'TK:CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'132', label_value=>'TK:KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'142', label_value=>'TK:CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'152', label_value=>'TK:TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'162', label_value=>'TK:MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'163', label_value=>'TK:HTTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'164', label_value=>'TK:CNPM:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'165', label_value=>'TK:KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'166', label_value=>'TK:CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'167', label_value=>'TK:TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'168', label_value=>'TK:MMT:CS1, CS2');

----C2
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1000', label_value=>'TK:HTTT,CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1001', label_value=>'TK:HTTT,KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1002', label_value=>'TK:HTTT,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1003', label_value=>'TK:HTTT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1004', label_value=>'TK:HTTT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1005', label_value=>'TK:CNPM,KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1006', label_value=>'TK:CNPM,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1007', label_value=>'TK:CNPM,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1008', label_value=>'TK:CNPM,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1009', label_value=>'TK:KHMT,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1010', label_value=>'TK:KHMT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1011', label_value=>'TK:KHMT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1012', label_value=>'TK:CNTT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1013', label_value=>'TK:CNTT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1014', label_value=>'TK:TGMT,MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1015', label_value=>'TK:HTTT,CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1016', label_value=>'TK:HTTT,KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1017', label_value=>'TK:HTTT,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1018', label_value=>'TK:HTTT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1019', label_value=>'TK:HTTT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1020', label_value=>'TK:CNPM,KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1021', label_value=>'TK:CNPM,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1022', label_value=>'TK:CNPM,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1023', label_value=>'TK:CNPM,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1024', label_value=>'TK:KHMT,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1025', label_value=>'TK:KHMT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1026', label_value=>'TK:KHMT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1027', label_value=>'TK:CNTT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1028', label_value=>'TK:CNTT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1029', label_value=>'TK:TGMT,MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1185', label_value=>'TK:HTTT,CNPM:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1186', label_value=>'TK:HTTT,KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1187', label_value=>'TK:HTTT,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1188', label_value=>'TK:HTTT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1189', label_value=>'TK:HTTT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1190', label_value=>'TK:CNPM,KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1191', label_value=>'TK:CNPM,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1192', label_value=>'TK:CNPM,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1193', label_value=>'TK:CNPM,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1194', label_value=>'TK:KHMT,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1195', label_value=>'TK:KHMT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1196', label_value=>'TK:KHMT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1197', label_value=>'TK:CNTT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1198', label_value=>'TK:CNTT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1199', label_value=>'TK:TGMT,MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1030', label_value=>'TK:HTTT,CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1031', label_value=>'TK:HTTT,KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1032', label_value=>'TK:HTTT,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1033', label_value=>'TK:HTTT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1034', label_value=>'TK:HTTT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1035', label_value=>'TK:CNPM,KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1036', label_value=>'TK:CNPM,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1037', label_value=>'TK:CNPM,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1038', label_value=>'TK:CNPM,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1039', label_value=>'TK:KHMT,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1040', label_value=>'TK:KHMT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1041', label_value=>'TK:KHMT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1042', label_value=>'TK:CNTT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1043', label_value=>'TK:CNTT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1044', label_value=>'TK:TGMT,MMT:');

--C3
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1045', label_value=>'TK:HTTT, CNPM, KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1046', label_value=>'TK:HTTT, CNPM, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1047', label_value=>'TK:HTTT, CNPM, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1048', label_value=>'TK:HTTT, CNPM, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1049', label_value=>'TK:HTTT, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1050', label_value=>'TK:HTTT, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1051', label_value=>'TK:HTTT, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1052', label_value=>'TK:HTTT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1053', label_value=>'TK:HTTT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1054', label_value=>'TK:HTTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1055', label_value=>'TK:CNPM, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1056', label_value=>'TK:CNPM, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1057', label_value=>'TK:CNPM, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1058', label_value=>'TK:CNPM, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1059', label_value=>'TK:CNPM, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1060', label_value=>'TK:CNPM, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1061', label_value=>'TK:KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1062', label_value=>'TK:KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1063', label_value=>'TK:KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1064', label_value=>'TK:CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1065', label_value=>'TK:HTTT, CNPM, KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1066', label_value=>'TK:HTTT, CNPM, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1067', label_value=>'TK:HTTT, CNPM, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1068', label_value=>'TK:HTTT, CNPM, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1069', label_value=>'TK:HTTT, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1070', label_value=>'TK:HTTT, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1071', label_value=>'TK:HTTT, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1072', label_value=>'TK:HTTT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1073', label_value=>'TK:HTTT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1074', label_value=>'TK:HTTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1075', label_value=>'TK:CNPM, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1076', label_value=>'TK:CNPM, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1077', label_value=>'TK:CNPM, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1078', label_value=>'TK:CNPM, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1079', label_value=>'TK:CNPM, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1080', label_value=>'TK:CNPM, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1081', label_value=>'TK:KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1082', label_value=>'TK:KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1083', label_value=>'TK:KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1084', label_value=>'TK:CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1165', label_value=>'TK:HTTT, CNPM, KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1166', label_value=>'TK:HTTT, CNPM, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1167', label_value=>'TK:HTTT, CNPM, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1168', label_value=>'TK:HTTT, CNPM, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1169', label_value=>'TK:HTTT, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1170', label_value=>'TK:HTTT, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1171', label_value=>'TK:HTTT, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1172', label_value=>'TK:HTTT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1173', label_value=>'TK:HTTT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1174', label_value=>'TK:HTTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1175', label_value=>'TK:CNPM, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1176', label_value=>'TK:CNPM, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1177', label_value=>'TK:CNPM, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1178', label_value=>'TK:CNPM, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1179', label_value=>'TK:CNPM, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1180', label_value=>'TK:CNPM, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1181', label_value=>'TK:KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1182', label_value=>'TK:KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1183', label_value=>'TK:KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1184', label_value=>'TK:CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1085', label_value=>'TK:HTTT, CNPM, KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1086', label_value=>'TK:HTTT, CNPM, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1087', label_value=>'TK:HTTT, CNPM, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1088', label_value=>'TK:HTTT, CNPM, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1089', label_value=>'TK:HTTT, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1090', label_value=>'TK:HTTT, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1091', label_value=>'TK:HTTT, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1092', label_value=>'TK:HTTT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1093', label_value=>'TK:HTTT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1094', label_value=>'TK:HTTT, TGMT, MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1095', label_value=>'TK:CNPM, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1096', label_value=>'TK:CNPM, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1097', label_value=>'TK:CNPM, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1098', label_value=>'TK:CNPM, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1099', label_value=>'TK:CNPM, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1100', label_value=>'TK:CNPM, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1101', label_value=>'TK:KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1102', label_value=>'TK:KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1103', label_value=>'TK:KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1104', label_value=>'TK:CNTT, TGMT, MMT:');

--C4
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1105', label_value=>'TK:HTTT, CNPM, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1106', label_value=>'TK:HTTT, CNPM, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1107', label_value=>'TK:HTTT, CNPM, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1108', label_value=>'TK:HTTT, CNPM, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1109', label_value=>'TK:HTTT, CNPM, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1110', label_value=>'TK:HTTT, CNPM, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1111', label_value=>'TK:HTTT, KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1112', label_value=>'TK:HTTT, KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1113', label_value=>'TK:HTTT, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1114', label_value=>'TK:HTTT, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1115', label_value=>'TK:CNPM, KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1116', label_value=>'TK:CNPM, KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1117', label_value=>'TK:CNPM, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1118', label_value=>'TK:CNPM, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1119', label_value=>'TK:KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1120', label_value=>'TK:HTTT, CNPM, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1121', label_value=>'TK:HTTT, CNPM, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1122', label_value=>'TK:HTTT, CNPM, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1123', label_value=>'TK:HTTT, CNPM, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1124', label_value=>'TK:HTTT, CNPM, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1125', label_value=>'TK:HTTT, CNPM, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1126', label_value=>'TK:HTTT, KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1127', label_value=>'TK:HTTT, KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1128', label_value=>'TK:HTTT, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1129', label_value=>'TK:HTTT, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1130', label_value=>'TK:CNPM, KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1131', label_value=>'TK:CNPM, KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1132', label_value=>'TK:CNPM, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1133', label_value=>'TK:CNPM, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1134', label_value=>'TK:KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1135', label_value=>'TK:HTTT, CNPM, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1136', label_value=>'TK:HTTT, CNPM, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1137', label_value=>'TK:HTTT, CNPM, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1138', label_value=>'TK:HTTT, CNPM, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1139', label_value=>'TK:HTTT, CNPM, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1140', label_value=>'TK:HTTT, CNPM, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1141', label_value=>'TK:HTTT, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1142', label_value=>'TK:HTTT, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1143', label_value=>'TK:HTTT, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1144', label_value=>'TK:HTTT, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1145', label_value=>'TK:CNPM, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1146', label_value=>'TK:CNPM, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1147', label_value=>'TK:CNPM, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1148', label_value=>'TK:CNPM, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1149', label_value=>'TK:KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1150', label_value=>'TK:HTTT, CNPM, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1151', label_value=>'TK:HTTT, CNPM, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1152', label_value=>'TK:HTTT, CNPM, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1153', label_value=>'TK:HTTT, CNPM, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1154', label_value=>'TK:HTTT, CNPM, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1155', label_value=>'TK:HTTT, CNPM, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1156', label_value=>'TK:HTTT, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1157', label_value=>'TK:HTTT, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1158', label_value=>'TK:HTTT, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1159', label_value=>'TK:HTTT, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1160', label_value=>'TK:CNPM, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1161', label_value=>'TK:CNPM, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1162', label_value=>'TK:CNPM, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1163', label_value=>'TK:CNPM, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1164', label_value=>'TK:KHMT, CNTT, TGMT, MMT:');

--C5
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1200', label_value=>'TK:HTTT, CNPM, KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1201', label_value=>'TK:HTTT, CNPM, KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1202', label_value=>'TK:HTTT, CNPM, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1203', label_value=>'TK:HTTT, CNPM, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1204', label_value=>'TK:HTTT, KHMT, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1205', label_value=>'TK:CNPM, KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1206', label_value=>'TK:HTTT, CNPM, KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1207', label_value=>'TK:HTTT, CNPM, KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1208', label_value=>'TK:HTTT, CNPM, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1209', label_value=>'TK:HTTT, CNPM, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1210', label_value=>'TK:HTTT, KHMT, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1211', label_value=>'TK:CNPM, KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1212', label_value=>'TK:HTTT, CNPM, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1213', label_value=>'TK:HTTT, CNPM, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1214', label_value=>'TK:HTTT, CNPM, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1215', label_value=>'TK:HTTT, CNPM, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1216', label_value=>'TK:HTTT, KHMT, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1217', label_value=>'TK:CNPM, KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1218', label_value=>'TK:HTTT, CNPM, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1219', label_value=>'TK:HTTT, CNPM, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1220', label_value=>'TK:HTTT, CNPM, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1221', label_value=>'TK:HTTT, CNPM, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1222', label_value=>'TK:HTTT, KHMT, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1223', label_value=>'TK:CNPM, KHMT, CNTT, TGMT, MMT:');

--C6
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1224', label_value=>'TK:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1225', label_value=>'TK:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1226', label_value=>'TK:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1227', label_value=>'TK:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:');


--TDV
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'200', label_value=>'TDV::');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'210', label_value=>'TDV:HTTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'220', label_value=>'TDV:CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'230', label_value=>'TDV:KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'240', label_value=>'TDV:CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'250', label_value=>'TDV:TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'260', label_value=>'TDV:MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'201', label_value=>'TDV::CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'202', label_value=>'TDV::CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'203', label_value=>'TDV::CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'211', label_value=>'TDV:HTTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'221', label_value=>'TDV:CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'231', label_value=>'TDV:KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'241', label_value=>'TDV:CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'251', label_value=>'TDV:TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'261', label_value=>'TDV:MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'212', label_value=>'TDV:HTTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'222', label_value=>'TDV:CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'232', label_value=>'TDV:KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'242', label_value=>'TDV:CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'252', label_value=>'TDV:TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'262', label_value=>'TDV:MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'263', label_value=>'TDV:HTTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'264', label_value=>'TDV:CNPM:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'265', label_value=>'TDV:KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'266', label_value=>'TDV:CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'267', label_value=>'TDV:TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'268', label_value=>'TDV:MMT:CS1, CS2');

--C2 
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1228', label_value=>'TDV:HTTT,CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1229', label_value=>'TDV:HTTT,KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1230', label_value=>'TDV:HTTT,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1231', label_value=>'TDV:HTTT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1232', label_value=>'TDV:HTTT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1233', label_value=>'TDV:CNPM,KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1234', label_value=>'TDV:CNPM,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1235', label_value=>'TDV:CNPM,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1236', label_value=>'TDV:CNPM,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1237', label_value=>'TDV:KHMT,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1238', label_value=>'TDV:KHMT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1239', label_value=>'TDV:KHMT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1240', label_value=>'TDV:CNTT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1241', label_value=>'TDV:CNTT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1242', label_value=>'TDV:TGMT,MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1243', label_value=>'TDV:HTTT,CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1244', label_value=>'TDV:HTTT,KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1245', label_value=>'TDV:HTTT,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1246', label_value=>'TDV:HTTT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1247', label_value=>'TDV:HTTT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1248', label_value=>'TDV:CNPM,KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1249', label_value=>'TDV:CNPM,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1250', label_value=>'TDV:CNPM,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1251', label_value=>'TDV:CNPM,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1252', label_value=>'TDV:KHMT,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1253', label_value=>'TDV:KHMT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1254', label_value=>'TDV:KHMT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1255', label_value=>'TDV:CNTT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1256', label_value=>'TDV:CNTT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1257', label_value=>'TDV:TGMT,MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1258', label_value=>'TDV:HTTT,CNPM:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1259', label_value=>'TDV:HTTT,KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1260', label_value=>'TDV:HTTT,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1261', label_value=>'TDV:HTTT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1262', label_value=>'TDV:HTTT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1263', label_value=>'TDV:CNPM,KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1264', label_value=>'TDV:CNPM,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1265', label_value=>'TDV:CNPM,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1266', label_value=>'TDV:CNPM,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1267', label_value=>'TDV:KHMT,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1268', label_value=>'TDV:KHMT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1269', label_value=>'TDV:KHMT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1270', label_value=>'TDV:CNTT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1271', label_value=>'TDV:CNTT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1272', label_value=>'TDV:TGMT,MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1273', label_value=>'TDV:HTTT,CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1274', label_value=>'TDV:HTTT,KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1275', label_value=>'TDV:HTTT,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1276', label_value=>'TDV:HTTT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1277', label_value=>'TDV:HTTT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1278', label_value=>'TDV:CNPM,KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1279', label_value=>'TDV:CNPM,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1280', label_value=>'TDV:CNPM,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1281', label_value=>'TDV:CNPM,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1282', label_value=>'TDV:KHMT,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1283', label_value=>'TDV:KHMT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1284', label_value=>'TDV:KHMT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1285', label_value=>'TDV:CNTT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1286', label_value=>'TDV:CNTT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1287', label_value=>'TDV:TGMT,MMT:');

--C3
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1288', label_value=>'TDV:HTTT, CNPM, KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1289', label_value=>'TDV:HTTT, CNPM, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1290', label_value=>'TDV:HTTT, CNPM, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1291', label_value=>'TDV:HTTT, CNPM, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1292', label_value=>'TDV:HTTT, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1293', label_value=>'TDV:HTTT, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1294', label_value=>'TDV:HTTT, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1295', label_value=>'TDV:HTTT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1296', label_value=>'TDV:HTTT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1297', label_value=>'TDV:HTTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1298', label_value=>'TDV:CNPM, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1299', label_value=>'TDV:CNPM, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1300', label_value=>'TDV:CNPM, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1301', label_value=>'TDV:CNPM, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1302', label_value=>'TDV:CNPM, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1303', label_value=>'TDV:CNPM, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1304', label_value=>'TDV:KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1305', label_value=>'TDV:KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1306', label_value=>'TDV:KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1307', label_value=>'TDV:CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1308', label_value=>'TDV:HTTT, CNPM, KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1309', label_value=>'TDV:HTTT, CNPM, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1310', label_value=>'TDV:HTTT, CNPM, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1311', label_value=>'TDV:HTTT, CNPM, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1312', label_value=>'TDV:HTTT, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1313', label_value=>'TDV:HTTT, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1314', label_value=>'TDV:HTTT, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1315', label_value=>'TDV:HTTT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1316', label_value=>'TDV:HTTT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1317', label_value=>'TDV:HTTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1318', label_value=>'TDV:CNPM, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1319', label_value=>'TDV:CNPM, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1320', label_value=>'TDV:CNPM, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1321', label_value=>'TDV:CNPM, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1322', label_value=>'TDV:CNPM, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1323', label_value=>'TDV:CNPM, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1324', label_value=>'TDV:KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1325', label_value=>'TDV:KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1326', label_value=>'TDV:KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1327', label_value=>'TDV:CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1328', label_value=>'TDV:HTTT, CNPM, KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1329', label_value=>'TDV:HTTT, CNPM, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1330', label_value=>'TDV:HTTT, CNPM, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1331', label_value=>'TDV:HTTT, CNPM, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1332', label_value=>'TDV:HTTT, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1333', label_value=>'TDV:HTTT, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1334', label_value=>'TDV:HTTT, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1335', label_value=>'TDV:HTTT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1336', label_value=>'TDV:HTTT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1337', label_value=>'TDV:HTTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1338', label_value=>'TDV:CNPM, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1339', label_value=>'TDV:CNPM, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1340', label_value=>'TDV:CNPM, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1341', label_value=>'TDV:CNPM, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1342', label_value=>'TDV:CNPM, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1343', label_value=>'TDV:CNPM, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1344', label_value=>'TDV:KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1345', label_value=>'TDV:KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1346', label_value=>'TDV:KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1347', label_value=>'TDV:CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1348', label_value=>'TDV:HTTT, CNPM, KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1349', label_value=>'TDV:HTTT, CNPM, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1350', label_value=>'TDV:HTTT, CNPM, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1351', label_value=>'TDV:HTTT, CNPM, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1352', label_value=>'TDV:HTTT, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1353', label_value=>'TDV:HTTT, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1354', label_value=>'TDV:HTTT, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1355', label_value=>'TDV:HTTT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1356', label_value=>'TDV:HTTT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1357', label_value=>'TDV:HTTT, TGMT, MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1358', label_value=>'TDV:CNPM, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1359', label_value=>'TDV:CNPM, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1360', label_value=>'TDV:CNPM, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1361', label_value=>'TDV:CNPM, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1362', label_value=>'TDV:CNPM, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1363', label_value=>'TDV:CNPM, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1364', label_value=>'TDV:KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1365', label_value=>'TDV:KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1366', label_value=>'TDV:KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1367', label_value=>'TDV:CNTT, TGMT, MMT:');

--C4
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1408', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1409', label_value=>'TDV:HTTT, CNPM, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1410', label_value=>'TDV:HTTT, CNPM, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1411', label_value=>'TDV:HTTT, CNPM, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1412', label_value=>'TDV:HTTT, CNPM, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1413', label_value=>'TDV:HTTT, CNPM, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1414', label_value=>'TDV:HTTT, KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1415', label_value=>'TDV:HTTT, KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1416', label_value=>'TDV:HTTT, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1417', label_value=>'TDV:HTTT, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1418', label_value=>'TDV:CNPM, KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1419', label_value=>'TDV:CNPM, KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1420', label_value=>'TDV:CNPM, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1421', label_value=>'TDV:CNPM, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1422', label_value=>'TDV:KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1423', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1424', label_value=>'TDV:HTTT, CNPM, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1425', label_value=>'TDV:HTTT, CNPM, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1426', label_value=>'TDV:HTTT, CNPM, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1427', label_value=>'TDV:HTTT, CNPM, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1428', label_value=>'TDV:HTTT, CNPM, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1429', label_value=>'TDV:HTTT, KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1430', label_value=>'TDV:HTTT, KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1431', label_value=>'TDV:HTTT, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1432', label_value=>'TDV:HTTT, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1433', label_value=>'TDV:CNPM, KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1434', label_value=>'TDV:CNPM, KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1435', label_value=>'TDV:CNPM, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1436', label_value=>'TDV:CNPM, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1437', label_value=>'TDV:KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1438', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1439', label_value=>'TDV:HTTT, CNPM, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1440', label_value=>'TDV:HTTT, CNPM, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1441', label_value=>'TDV:HTTT, CNPM, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1442', label_value=>'TDV:HTTT, CNPM, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1443', label_value=>'TDV:HTTT, CNPM, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1444', label_value=>'TDV:HTTT, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1445', label_value=>'TDV:HTTT, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1446', label_value=>'TDV:HTTT, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1447', label_value=>'TDV:HTTT, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1448', label_value=>'TDV:CNPM, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1449', label_value=>'TDV:CNPM, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1450', label_value=>'TDV:CNPM, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1451', label_value=>'TDV:CNPM, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1452', label_value=>'TDV:KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1453', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1454', label_value=>'TDV:HTTT, CNPM, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1455', label_value=>'TDV:HTTT, CNPM, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1456', label_value=>'TDV:HTTT, CNPM, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1457', label_value=>'TDV:HTTT, CNPM, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1458', label_value=>'TDV:HTTT, CNPM, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1459', label_value=>'TDV:HTTT, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1460', label_value=>'TDV:HTTT, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1461', label_value=>'TDV:HTTT, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1462', label_value=>'TDV:HTTT, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1463', label_value=>'TDV:CNPM, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1464', label_value=>'TDV:CNPM, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1465', label_value=>'TDV:CNPM, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1466', label_value=>'TDV:CNPM, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1467', label_value=>'TDV:KHMT, CNTT, TGMT, MMT:');

--C5
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1468', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1469', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1470', label_value=>'TDV:HTTT, CNPM, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1471', label_value=>'TDV:HTTT, CNPM, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1472', label_value=>'TDV:HTTT, KHMT, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1473', label_value=>'TDV:CNPM, KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1474', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1475', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1476', label_value=>'TDV:HTTT, CNPM, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1477', label_value=>'TDV:HTTT, CNPM, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1478', label_value=>'TDV:HTTT, KHMT, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1479', label_value=>'TDV:CNPM, KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1480', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1481', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1482', label_value=>'TDV:HTTT, CNPM, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1483', label_value=>'TDV:HTTT, CNPM, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1484', label_value=>'TDV:HTTT, KHMT, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1485', label_value=>'TDV:CNPM, KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1486', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1487', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1488', label_value=>'TDV:HTTT, CNPM, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1489', label_value=>'TDV:HTTT, CNPM, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1490', label_value=>'TDV:HTTT, KHMT, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1491', label_value=>'TDV:CNPM, KHMT, CNTT, TGMT, MMT:');

--C6
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1492', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1493', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1494', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1495', label_value=>'TDV:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:');

--GVIEN
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'300', label_value=>'GVIEN::');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'310', label_value=>'GVIEN:HTTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'320', label_value=>'GVIEN:CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'330', label_value=>'GVIEN:KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'340', label_value=>'GVIEN:CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'350', label_value=>'GVIEN:TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'360', label_value=>'GVIEN:MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'301', label_value=>'GVIEN::CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'302', label_value=>'GVIEN::CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'303', label_value=>'GVIEN::CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'311', label_value=>'GVIEN:HTTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'321', label_value=>'GVIEN:CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'331', label_value=>'GVIEN:KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'341', label_value=>'GVIEN:CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'351', label_value=>'GVIEN:TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'361', label_value=>'GVIEN:MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'312', label_value=>'GVIEN:HTTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'322', label_value=>'GVIEN:CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'332', label_value=>'GVIEN:KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'342', label_value=>'GVIEN:CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'352', label_value=>'GVIEN:TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'362', label_value=>'GVIEN:MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'363', label_value=>'GVIEN:HTTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'364', label_value=>'GVIEN:CNPM:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'365', label_value=>'GVIEN:KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'366', label_value=>'GVIEN:CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'367', label_value=>'GVIEN:TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'368', label_value=>'GVIEN:MMT:CS1, CS2');

--C2 
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1496', label_value=>'GVIEN:HTTT,CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1497', label_value=>'GVIEN:HTTT,KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1498', label_value=>'GVIEN:HTTT,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1499', label_value=>'GVIEN:HTTT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1500', label_value=>'GVIEN:HTTT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1501', label_value=>'GVIEN:CNPM,KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1502', label_value=>'GVIEN:CNPM,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1503', label_value=>'GVIEN:CNPM,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1504', label_value=>'GVIEN:CNPM,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1505', label_value=>'GVIEN:KHMT,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1506', label_value=>'GVIEN:KHMT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1507', label_value=>'GVIEN:KHMT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1508', label_value=>'GVIEN:CNTT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1509', label_value=>'GVIEN:CNTT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1510', label_value=>'GVIEN:TGMT,MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1511', label_value=>'GVIEN:HTTT,CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1512', label_value=>'GVIEN:HTTT,KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1513', label_value=>'GVIEN:HTTT,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1514', label_value=>'GVIEN:HTTT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1515', label_value=>'GVIEN:HTTT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1516', label_value=>'GVIEN:CNPM,KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1517', label_value=>'GVIEN:CNPM,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1518', label_value=>'GVIEN:CNPM,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1519', label_value=>'GVIEN:CNPM,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1520', label_value=>'GVIEN:KHMT,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1521', label_value=>'GVIEN:KHMT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1522', label_value=>'GVIEN:KHMT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1523', label_value=>'GVIEN:CNTT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1524', label_value=>'GVIEN:CNTT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1525', label_value=>'GVIEN:TGMT,MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1526', label_value=>'GVIEN:HTTT,CNPM:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1527', label_value=>'GVIEN:HTTT,KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1528', label_value=>'GVIEN:HTTT,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1529', label_value=>'GVIEN:HTTT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1530', label_value=>'GVIEN:HTTT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1531', label_value=>'GVIEN:CNPM,KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1532', label_value=>'GVIEN:CNPM,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1533', label_value=>'GVIEN:CNPM,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1534', label_value=>'GVIEN:CNPM,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1535', label_value=>'GVIEN:KHMT,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1536', label_value=>'GVIEN:KHMT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1537', label_value=>'GVIEN:KHMT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1538', label_value=>'GVIEN:CNTT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1539', label_value=>'GVIEN:CNTT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1540', label_value=>'GVIEN:TGMT,MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1541', label_value=>'GVIEN:HTTT,CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1542', label_value=>'GVIEN:HTTT,KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1543', label_value=>'GVIEN:HTTT,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1544', label_value=>'GVIEN:HTTT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1545', label_value=>'GVIEN:HTTT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1546', label_value=>'GVIEN:CNPM,KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1547', label_value=>'GVIEN:CNPM,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1548', label_value=>'GVIEN:CNPM,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1549', label_value=>'GVIEN:CNPM,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1550', label_value=>'GVIEN:KHMT,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1551', label_value=>'GVIEN:KHMT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1552', label_value=>'GVIEN:KHMT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1553', label_value=>'GVIEN:CNTT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1554', label_value=>'GVIEN:CNTT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1555', label_value=>'GVIEN:TGMT,MMT:');

--C3 
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1556', label_value=>'GVIEN:HTTT, CNPM, KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1557', label_value=>'GVIEN:HTTT, CNPM, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1558', label_value=>'GVIEN:HTTT, CNPM, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1559', label_value=>'GVIEN:HTTT, CNPM, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1560', label_value=>'GVIEN:HTTT, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1561', label_value=>'GVIEN:HTTT, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1562', label_value=>'GVIEN:HTTT, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1563', label_value=>'GVIEN:HTTT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1564', label_value=>'GVIEN:HTTT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1565', label_value=>'GVIEN:HTTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1566', label_value=>'GVIEN:CNPM, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1567', label_value=>'GVIEN:CNPM, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1568', label_value=>'GVIEN:CNPM, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1569', label_value=>'GVIEN:CNPM, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1570', label_value=>'GVIEN:CNPM, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1571', label_value=>'GVIEN:CNPM, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1572', label_value=>'GVIEN:KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1573', label_value=>'GVIEN:KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1574', label_value=>'GVIEN:KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1575', label_value=>'GVIEN:CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1576', label_value=>'GVIEN:HTTT, CNPM, KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1577', label_value=>'GVIEN:HTTT, CNPM, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1578', label_value=>'GVIEN:HTTT, CNPM, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1579', label_value=>'GVIEN:HTTT, CNPM, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1580', label_value=>'GVIEN:HTTT, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1581', label_value=>'GVIEN:HTTT, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1582', label_value=>'GVIEN:HTTT, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1583', label_value=>'GVIEN:HTTT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1584', label_value=>'GVIEN:HTTT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1585', label_value=>'GVIEN:HTTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1586', label_value=>'GVIEN:CNPM, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1587', label_value=>'GVIEN:CNPM, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1588', label_value=>'GVIEN:CNPM, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1589', label_value=>'GVIEN:CNPM, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1590', label_value=>'GVIEN:CNPM, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1591', label_value=>'GVIEN:CNPM, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1592', label_value=>'GVIEN:KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1593', label_value=>'GVIEN:KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1594', label_value=>'GVIEN:KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1595', label_value=>'GVIEN:CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1596', label_value=>'GVIEN:HTTT, CNPM, KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1597', label_value=>'GVIEN:HTTT, CNPM, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1598', label_value=>'GVIEN:HTTT, CNPM, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1599', label_value=>'GVIEN:HTTT, CNPM, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1600', label_value=>'GVIEN:HTTT, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1601', label_value=>'GVIEN:HTTT, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1602', label_value=>'GVIEN:HTTT, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1603', label_value=>'GVIEN:HTTT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1604', label_value=>'GVIEN:HTTT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1605', label_value=>'GVIEN:HTTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1606', label_value=>'GVIEN:CNPM, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1607', label_value=>'GVIEN:CNPM, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1608', label_value=>'GVIEN:CNPM, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1609', label_value=>'GVIEN:CNPM, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1610', label_value=>'GVIEN:CNPM, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1611', label_value=>'GVIEN:CNPM, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1612', label_value=>'GVIEN:KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1613', label_value=>'GVIEN:KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1614', label_value=>'GVIEN:KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1615', label_value=>'GVIEN:CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1616', label_value=>'GVIEN:HTTT, CNPM, KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1617', label_value=>'GVIEN:HTTT, CNPM, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1618', label_value=>'GVIEN:HTTT, CNPM, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1619', label_value=>'GVIEN:HTTT, CNPM, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1620', label_value=>'GVIEN:HTTT, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1621', label_value=>'GVIEN:HTTT, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1622', label_value=>'GVIEN:HTTT, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1623', label_value=>'GVIEN:HTTT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1624', label_value=>'GVIEN:HTTT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1625', label_value=>'GVIEN:HTTT, TGMT, MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1626', label_value=>'GVIEN:CNPM, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1627', label_value=>'GVIEN:CNPM, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1628', label_value=>'GVIEN:CNPM, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1629', label_value=>'GVIEN:CNPM, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1630', label_value=>'GVIEN:CNPM, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1631', label_value=>'GVIEN:CNPM, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1632', label_value=>'GVIEN:KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1633', label_value=>'GVIEN:KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1634', label_value=>'GVIEN:KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1635', label_value=>'GVIEN:CNTT, TGMT, MMT:');

--C4
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1636', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1637', label_value=>'GVIEN:HTTT, CNPM, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1638', label_value=>'GVIEN:HTTT, CNPM, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1639', label_value=>'GVIEN:HTTT, CNPM, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1640', label_value=>'GVIEN:HTTT, CNPM, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1641', label_value=>'GVIEN:HTTT, CNPM, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1642', label_value=>'GVIEN:HTTT, KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1643', label_value=>'GVIEN:HTTT, KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1644', label_value=>'GVIEN:HTTT, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1645', label_value=>'GVIEN:HTTT, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1646', label_value=>'GVIEN:CNPM, KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1647', label_value=>'GVIEN:CNPM, KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1648', label_value=>'GVIEN:CNPM, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1649', label_value=>'GVIEN:CNPM, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1650', label_value=>'GVIEN:KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1651', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1652', label_value=>'GVIEN:HTTT, CNPM, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1653', label_value=>'GVIEN:HTTT, CNPM, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1654', label_value=>'GVIEN:HTTT, CNPM, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1655', label_value=>'GVIEN:HTTT, CNPM, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1656', label_value=>'GVIEN:HTTT, CNPM, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1657', label_value=>'GVIEN:HTTT, KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1658', label_value=>'GVIEN:HTTT, KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1659', label_value=>'GVIEN:HTTT, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1660', label_value=>'GVIEN:HTTT, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1661', label_value=>'GVIEN:CNPM, KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1662', label_value=>'GVIEN:CNPM, KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1663', label_value=>'GVIEN:CNPM, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1664', label_value=>'GVIEN:CNPM, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1665', label_value=>'GVIEN:KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1666', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1667', label_value=>'GVIEN:HTTT, CNPM, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1668', label_value=>'GVIEN:HTTT, CNPM, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1669', label_value=>'GVIEN:HTTT, CNPM, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1670', label_value=>'GVIEN:HTTT, CNPM, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1671', label_value=>'GVIEN:HTTT, CNPM, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1672', label_value=>'GVIEN:HTTT, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1673', label_value=>'GVIEN:HTTT, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1674', label_value=>'GVIEN:HTTT, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1675', label_value=>'GVIEN:HTTT, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1676', label_value=>'GVIEN:CNPM, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1677', label_value=>'GVIEN:CNPM, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1678', label_value=>'GVIEN:CNPM, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1679', label_value=>'GVIEN:CNPM, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1680', label_value=>'GVIEN:KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1681', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1682', label_value=>'GVIEN:HTTT, CNPM, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1683', label_value=>'GVIEN:HTTT, CNPM, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1684', label_value=>'GVIEN:HTTT, CNPM, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1685', label_value=>'GVIEN:HTTT, CNPM, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1686', label_value=>'GVIEN:HTTT, CNPM, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1687', label_value=>'GVIEN:HTTT, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1688', label_value=>'GVIEN:HTTT, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1689', label_value=>'GVIEN:HTTT, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1690', label_value=>'GVIEN:HTTT, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1691', label_value=>'GVIEN:CNPM, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1692', label_value=>'GVIEN:CNPM, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1693', label_value=>'GVIEN:CNPM, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1694', label_value=>'GVIEN:CNPM, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1695', label_value=>'GVIEN:KHMT, CNTT, TGMT, MMT:');

--C5
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1696', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1697', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1698', label_value=>'GVIEN:HTTT, CNPM, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1699', label_value=>'GVIEN:HTTT, CNPM, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1700', label_value=>'GVIEN:HTTT, KHMT, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1701', label_value=>'GVIEN:CNPM, KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1702', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1703', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1704', label_value=>'GVIEN:HTTT, CNPM, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1705', label_value=>'GVIEN:HTTT, CNPM, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1706', label_value=>'GVIEN:HTTT, KHMT, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1707', label_value=>'GVIEN:CNPM, KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1708', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1709', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1710', label_value=>'GVIEN:HTTT, CNPM, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1711', label_value=>'GVIEN:HTTT, CNPM, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1712', label_value=>'GVIEN:HTTT, KHMT, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1713', label_value=>'GVIEN:CNPM, KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1714', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1715', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1716', label_value=>'GVIEN:HTTT, CNPM, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1717', label_value=>'GVIEN:HTTT, CNPM, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1718', label_value=>'GVIEN:HTTT, KHMT, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1719', label_value=>'GVIEN:CNPM, KHMT, CNTT, TGMT, MMT:');

--C6
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1720', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1721', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1722', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1723', label_value=>'GVIEN:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:');

--GVU
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'400', label_value=>'GVU::');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'410', label_value=>'GVU:HTTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'420', label_value=>'GVU:CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'430', label_value=>'GVU:KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'440', label_value=>'GVU:CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'450', label_value=>'GVU:TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'460', label_value=>'GVU:MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'401', label_value=>'GVU::CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'402', label_value=>'GVU::CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'403', label_value=>'GVU::CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'411', label_value=>'GVU:HTTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'421', label_value=>'GVU:CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'431', label_value=>'GVU:KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'441', label_value=>'GVU:CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'451', label_value=>'GVU:TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'461', label_value=>'GVU:MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'412', label_value=>'GVU:HTTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'422', label_value=>'GVU:CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'432', label_value=>'GVU:KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'442', label_value=>'GVU:CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'452', label_value=>'GVU:TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'462', label_value=>'GVU:MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'463', label_value=>'GVU:HTTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'464', label_value=>'GVU:CNPM:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'465', label_value=>'GVU:KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'466', label_value=>'GVU:CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'467', label_value=>'GVU:TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'468', label_value=>'GVU:MMT:CS1, CS2');

--C2
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1724', label_value=>'GVU:HTTT,CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1725', label_value=>'GVU:HTTT,KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1726', label_value=>'GVU:HTTT,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1727', label_value=>'GVU:HTTT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1728', label_value=>'GVU:HTTT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1729', label_value=>'GVU:CNPM,KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1730', label_value=>'GVU:CNPM,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1731', label_value=>'GVU:CNPM,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1732', label_value=>'GVU:CNPM,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1733', label_value=>'GVU:KHMT,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1734', label_value=>'GVU:KHMT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1735', label_value=>'GVU:KHMT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1736', label_value=>'GVU:CNTT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1737', label_value=>'GVU:CNTT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1738', label_value=>'GVU:TGMT,MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1739', label_value=>'GVU:HTTT,CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1740', label_value=>'GVU:HTTT,KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1741', label_value=>'GVU:HTTT,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1742', label_value=>'GVU:HTTT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1743', label_value=>'GVU:HTTT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1744', label_value=>'GVU:CNPM,KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1745', label_value=>'GVU:CNPM,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1746', label_value=>'GVU:CNPM,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1747', label_value=>'GVU:CNPM,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1748', label_value=>'GVU:KHMT,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1749', label_value=>'GVU:KHMT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1750', label_value=>'GVU:KHMT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1751', label_value=>'GVU:CNTT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1752', label_value=>'GVU:CNTT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1753', label_value=>'GVU:TGMT,MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1754', label_value=>'GVU:HTTT,CNPM:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1755', label_value=>'GVU:HTTT,KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1756', label_value=>'GVU:HTTT,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1757', label_value=>'GVU:HTTT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1758', label_value=>'GVU:HTTT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1759', label_value=>'GVU:CNPM,KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1760', label_value=>'GVU:CNPM,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1761', label_value=>'GVU:CNPM,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1762', label_value=>'GVU:CNPM,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1763', label_value=>'GVU:KHMT,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1764', label_value=>'GVU:KHMT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1765', label_value=>'GVU:KHMT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1766', label_value=>'GVU:CNTT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1767', label_value=>'GVU:CNTT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1768', label_value=>'GVU:TGMT,MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1769', label_value=>'GVU:HTTT,CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1770', label_value=>'GVU:HTTT,KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1771', label_value=>'GVU:HTTT,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1772', label_value=>'GVU:HTTT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1773', label_value=>'GVU:HTTT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1774', label_value=>'GVU:CNPM,KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1775', label_value=>'GVU:CNPM,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1776', label_value=>'GVU:CNPM,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1777', label_value=>'GVU:CNPM,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1778', label_value=>'GVU:KHMT,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1779', label_value=>'GVU:KHMT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1780', label_value=>'GVU:KHMT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1781', label_value=>'GVU:CNTT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1782', label_value=>'GVU:CNTT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1783', label_value=>'GVU:TGMT,MMT:');

--C3
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1785', label_value=>'GVU:HTTT, CNPM, KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1786', label_value=>'GVU:HTTT, CNPM, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1787', label_value=>'GVU:HTTT, CNPM, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1788', label_value=>'GVU:HTTT, CNPM, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1789', label_value=>'GVU:HTTT, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1790', label_value=>'GVU:HTTT, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1791', label_value=>'GVU:HTTT, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1792', label_value=>'GVU:HTTT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1793', label_value=>'GVU:HTTT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1794', label_value=>'GVU:HTTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1795', label_value=>'GVU:CNPM, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1796', label_value=>'GVU:CNPM, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1797', label_value=>'GVU:CNPM, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1798', label_value=>'GVU:CNPM, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1799', label_value=>'GVU:CNPM, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1800', label_value=>'GVU:CNPM, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1801', label_value=>'GVU:KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1802', label_value=>'GVU:KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1803', label_value=>'GVU:KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1784', label_value=>'GVU:CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1804', label_value=>'GVU:HTTT, CNPM, KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1805', label_value=>'GVU:HTTT, CNPM, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1806', label_value=>'GVU:HTTT, CNPM, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1807', label_value=>'GVU:HTTT, CNPM, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1808', label_value=>'GVU:HTTT, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1809', label_value=>'GVU:HTTT, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1810', label_value=>'GVU:HTTT, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1811', label_value=>'GVU:HTTT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1812', label_value=>'GVU:HTTT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1813', label_value=>'GVU:HTTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1814', label_value=>'GVU:CNPM, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1815', label_value=>'GVU:CNPM, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1816', label_value=>'GVU:CNPM, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1817', label_value=>'GVU:CNPM, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1818', label_value=>'GVU:CNPM, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1819', label_value=>'GVU:CNPM, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1820', label_value=>'GVU:KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1821', label_value=>'GVU:KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1822', label_value=>'GVU:KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1823', label_value=>'GVU:CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1824', label_value=>'GVU:HTTT, CNPM, KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1825', label_value=>'GVU:HTTT, CNPM, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1826', label_value=>'GVU:HTTT, CNPM, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1827', label_value=>'GVU:HTTT, CNPM, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1828', label_value=>'GVU:HTTT, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1829', label_value=>'GVU:HTTT, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1830', label_value=>'GVU:HTTT, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1831', label_value=>'GVU:HTTT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1832', label_value=>'GVU:HTTT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1833', label_value=>'GVU:HTTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1834', label_value=>'GVU:CNPM, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1835', label_value=>'GVU:CNPM, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1836', label_value=>'GVU:CNPM, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1837', label_value=>'GVU:CNPM, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1838', label_value=>'GVU:CNPM, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1839', label_value=>'GVU:CNPM, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1840', label_value=>'GVU:KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1841', label_value=>'GVU:KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1842', label_value=>'GVU:KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1843', label_value=>'GVU:CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1844', label_value=>'GVU:HTTT, CNPM, KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1845', label_value=>'GVU:HTTT, CNPM, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1846', label_value=>'GVU:HTTT, CNPM, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1847', label_value=>'GVU:HTTT, CNPM, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1848', label_value=>'GVU:HTTT, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1849', label_value=>'GVU:HTTT, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1850', label_value=>'GVU:HTTT, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1851', label_value=>'GVU:HTTT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1852', label_value=>'GVU:HTTT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1853', label_value=>'GVU:HTTT, TGMT, MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1854', label_value=>'GVU:CNPM, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1855', label_value=>'GVU:CNPM, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1856', label_value=>'GVU:CNPM, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1857', label_value=>'GVU:CNPM, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1858', label_value=>'GVU:CNPM, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1859', label_value=>'GVU:CNPM, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1860', label_value=>'GVU:KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1861', label_value=>'GVU:KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1862', label_value=>'GVU:KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1863', label_value=>'GVU:CNTT, TGMT, MMT:');

--C4
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1864', label_value=>'GVU:HTTT, CNPM, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1865', label_value=>'GVU:HTTT, CNPM, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1866', label_value=>'GVU:HTTT, CNPM, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1867', label_value=>'GVU:HTTT, CNPM, CNtT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1868', label_value=>'GVU:HTTT, CNPM, CNtT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1869', label_value=>'GVU:HTTT, CNPM, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1870', label_value=>'GVU:HTTT, KHMT, CNtT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1871', label_value=>'GVU:HTTT, KHMT, CNtT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1872', label_value=>'GVU:HTTT, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1873', label_value=>'GVU:HTTT, CNtT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1874', label_value=>'GVU:CNPM, KHMT, CNtT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1875', label_value=>'GVU:CNPM, KHMT, CNtT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1876', label_value=>'GVU:CNPM, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1877', label_value=>'GVU:CNPM, CNtT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1878', label_value=>'GVU:KHMT, CNtT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1879', label_value=>'GVU:HTTT, CNPM, KHMT, CNtT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1880', label_value=>'GVU:HTTT, CNPM, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1881', label_value=>'GVU:HTTT, CNPM, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1882', label_value=>'GVU:HTTT, CNPM, CNtT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1883', label_value=>'GVU:HTTT, CNPM, CNtT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1884', label_value=>'GVU:HTTT, CNPM, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1885', label_value=>'GVU:HTTT, KHMT, CNtT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1886', label_value=>'GVU:HTTT, KHMT, CNtT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1887', label_value=>'GVU:HTTT, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1888', label_value=>'GVU:HTTT, CNtT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1889', label_value=>'GVU:CNPM, KHMT, CNtT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1890', label_value=>'GVU:CNPM, KHMT, CNtT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1891', label_value=>'GVU:CNPM, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1892', label_value=>'GVU:CNPM, CNtT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1893', label_value=>'GVU:KHMT, CNtT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1894', label_value=>'GVU:HTTT, CNPM, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1895', label_value=>'GVU:HTTT, CNPM, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1896', label_value=>'GVU:HTTT, CNPM, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1897', label_value=>'GVU:HTTT, CNPM, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1898', label_value=>'GVU:HTTT, CNPM, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1899', label_value=>'GVU:HTTT, CNPM, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1900', label_value=>'GVU:HTTT, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1901', label_value=>'GVU:HTTT, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1902', label_value=>'GVU:HTTT, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1903', label_value=>'GVU:HTTT, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1904', label_value=>'GVU:CNPM, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1905', label_value=>'GVU:CNPM, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1906', label_value=>'GVU:CNPM, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1907', label_value=>'GVU:CNPM, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1908', label_value=>'GVU:KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1909', label_value=>'GVU:HTTT, CNPM, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1910', label_value=>'GVU:HTTT, CNPM, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1911', label_value=>'GVU:HTTT, CNPM, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1912', label_value=>'GVU:HTTT, CNPM, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1913', label_value=>'GVU:HTTT, CNPM, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1914', label_value=>'GVU:HTTT, CNPM, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1915', label_value=>'GVU:HTTT, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1916', label_value=>'GVU:HTTT, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1917', label_value=>'GVU:HTTT, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1918', label_value=>'GVU:HTTT, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1919', label_value=>'GVU:CNPM, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1920', label_value=>'GVU:CNPM, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1921', label_value=>'GVU:CNPM, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1922', label_value=>'GVU:CNPM, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1923', label_value=>'GVU:KHMT, CNTT, TGMT, MMT:');

--C5
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1924', label_value=>'GVU:HTTT, CNPM, KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1925', label_value=>'GVU:HTTT, CNPM, KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1926', label_value=>'GVU:HTTT, CNPM, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1927', label_value=>'GVU:HTTT, CNPM, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1928', label_value=>'GVU:HTTT, KHMT, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1929', label_value=>'GVU:CNPM, KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1930', label_value=>'GVU:HTTT, CNPM, KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1931', label_value=>'GVU:HTTT, CNPM, KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1932', label_value=>'GVU:HTTT, CNPM, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1933', label_value=>'GVU:HTTT, CNPM, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1934', label_value=>'GVU:HTTT, KHMT, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1935', label_value=>'GVU:CNPM, KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1936', label_value=>'GVU:HTTT, CNPM, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1937', label_value=>'GVU:HTTT, CNPM, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1938', label_value=>'GVU:HTTT, CNPM, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1939', label_value=>'GVU:HTTT, CNPM, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1940', label_value=>'GVU:HTTT, KHMT, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1941', label_value=>'GVU:CNPM, KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1942', label_value=>'GVU:HTTT, CNPM, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1943', label_value=>'GVU:HTTT, CNPM, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1944', label_value=>'GVU:HTTT, CNPM, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1945', label_value=>'GVU:HTTT, CNPM, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1946', label_value=>'GVU:HTTT, KHMT, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1947', label_value=>'GVU:CNPM, KHMT, CNTT, TGMT, MMT:');

--C6
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1948', label_value=>'GVU:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1949', label_value=>'GVU:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1950', label_value=>'GVU:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'1951', label_value=>'GVU:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:');

--NV
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'500', label_value=>'NV::');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'510', label_value=>'NV:HTTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'520', label_value=>'NV:CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'530', label_value=>'NV:KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'540', label_value=>'NV:CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'550', label_value=>'NV:TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'560', label_value=>'NV:MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'501', label_value=>'NV::CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'502', label_value=>'NV::CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'503', label_value=>'NV::CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'511', label_value=>'NV:HTTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'521', label_value=>'NV:CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'531', label_value=>'NV:KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'541', label_value=>'NV:CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'551', label_value=>'NV:TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'561', label_value=>'NV:MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'512', label_value=>'NV:HTTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'522', label_value=>'NV:CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'532', label_value=>'NV:KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'542', label_value=>'NV:CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'552', label_value=>'NV:TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'562', label_value=>'NV:MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'563', label_value=>'NV:HTTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'564', label_value=>'NV:CNPM:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'565', label_value=>'NV:KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'566', label_value=>'NV:CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'567', label_value=>'NV:TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'568', label_value=>'NV:MMT:CS1, CS2');

--C2
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2000', label_value=>'NV:HTTT,CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2001', label_value=>'NV:HTTT,KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2002', label_value=>'NV:HTTT,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2003', label_value=>'NV:HTTT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2004', label_value=>'NV:HTTT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2005', label_value=>'NV:CNPM,KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2006', label_value=>'NV:CNPM,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2007', label_value=>'NV:CNPM,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2008', label_value=>'NV:CNPM,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2009', label_value=>'NV:KHMT,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2010', label_value=>'NV:KHMT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2011', label_value=>'NV:KHMT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2012', label_value=>'NV:CNTT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2013', label_value=>'NV:CNTT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2014', label_value=>'NV:TGMT,MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2015', label_value=>'NV:HTTT,CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2016', label_value=>'NV:HTTT,KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2017', label_value=>'NV:HTTT,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2018', label_value=>'NV:HTTT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2019', label_value=>'NV:HTTT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2020', label_value=>'NV:CNPM,KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2021', label_value=>'NV:CNPM,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2022', label_value=>'NV:CNPM,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2023', label_value=>'NV:CNPM,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2024', label_value=>'NV:KHMT,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2025', label_value=>'NV:KHMT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2026', label_value=>'NV:KHMT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2027', label_value=>'NV:CNTT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2028', label_value=>'NV:CNTT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2029', label_value=>'NV:TGMT,MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2030', label_value=>'NV:HTTT,CNPM:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2031', label_value=>'NV:HTTT,KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2032', label_value=>'NV:HTTT,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2033', label_value=>'NV:HTTT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2034', label_value=>'NV:HTTT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2035', label_value=>'NV:CNPM,KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2036', label_value=>'NV:CNPM,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2037', label_value=>'NV:CNPM,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2038', label_value=>'NV:CNPM,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2039', label_value=>'NV:KHMT,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2040', label_value=>'NV:KHMT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2041', label_value=>'NV:KHMT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2042', label_value=>'NV:CNTT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2043', label_value=>'NV:CNTT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2044', label_value=>'NV:TGMT,MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2045', label_value=>'NV:HTTT,CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2046', label_value=>'NV:HTTT,KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2047', label_value=>'NV:HTTT,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2048', label_value=>'NV:HTTT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2049', label_value=>'NV:HTTT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2050', label_value=>'NV:CNPM,KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2051', label_value=>'NV:CNPM,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2052', label_value=>'NV:CNPM,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2053', label_value=>'NV:CNPM,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2054', label_value=>'NV:KHMT,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2055', label_value=>'NV:KHMT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2056', label_value=>'NV:KHMT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2057', label_value=>'NV:CNTT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2058', label_value=>'NV:CNTT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2059', label_value=>'NV:TGMT,MMT:');

--C3
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2060', label_value=>'NV:HTTT,CNPM,KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2061', label_value=>'NV:HTTT,CNPM,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2062', label_value=>'NV:HTTT,CNPM,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2063', label_value=>'NV:HTTT,CNPM,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2064', label_value=>'NV:HTTT,KHMT,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2065', label_value=>'NV:HTTT,KHMT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2066', label_value=>'NV:HTTT,KHMT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2067', label_value=>'NV:HTTT,CNTT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2068', label_value=>'NV:HTTT,CNTT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2069', label_value=>'NV:HTTT,TGMT,MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2070', label_value=>'NV:CNPM,KHMT,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2071', label_value=>'NV:CNPM,KHMT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2072', label_value=>'NV:CNPM,KHMT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2073', label_value=>'NV:CNPM,CNTT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2074', label_value=>'NV:CNPM,CNTT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2075', label_value=>'NV:CNPM,TGMT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2076', label_value=>'NV:KHMT,CNTT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2077', label_value=>'NV:KHMT,CNTT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2078', label_value=>'NV:KHMT,TGMT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2079', label_value=>'NV:CNTT,TGMT,MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2080', label_value=>'NV:HTTT, CNPM, KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2081', label_value=>'NV:HTTT, CNPM, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2082', label_value=>'NV:HTTT, CNPM, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2083', label_value=>'NV:HTTT, CNPM, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2084', label_value=>'NV:HTTT, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2085', label_value=>'NV:HTTT, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2086', label_value=>'NV:HTTT, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2087', label_value=>'NV:HTTT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2088', label_value=>'NV:HTTT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2089', label_value=>'NV:HTTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2090', label_value=>'NV:CNPM, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2091', label_value=>'NV:CNPM, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2092', label_value=>'NV:CNPM, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2093', label_value=>'NV:CNPM, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2094', label_value=>'NV:CNPM, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2095', label_value=>'NV:CNPM, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2096', label_value=>'NV:KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2097', label_value=>'NV:KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2098', label_value=>'NV:KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2099', label_value=>'NV:CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2100', label_value=>'NV:HTTT, CNPM, KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2101', label_value=>'NV:HTTT, CNPM, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2102', label_value=>'NV:HTTT, CNPM, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2103', label_value=>'NV:HTTT, CNPM, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2104', label_value=>'NV:HTTT, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2105', label_value=>'NV:HTTT, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2106', label_value=>'NV:HTTT, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2107', label_value=>'NV:HTTT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2108', label_value=>'NV:HTTT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2109', label_value=>'NV:HTTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2110', label_value=>'NV:CNPM, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2111', label_value=>'NV:CNPM, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2112', label_value=>'NV:CNPM, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2113', label_value=>'NV:CNPM, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2114', label_value=>'NV:CNPM, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2115', label_value=>'NV:CNPM, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2116', label_value=>'NV:KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2117', label_value=>'NV:KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2118', label_value=>'NV:KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2119', label_value=>'NV:CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2120', label_value=>'NV:HTTT, CNPM, KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2121', label_value=>'NV:HTTT, CNPM, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2122', label_value=>'NV:HTTT, CNPM, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2123', label_value=>'NV:HTTT, CNPM, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2124', label_value=>'NV:HTTT, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2125', label_value=>'NV:HTTT, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2126', label_value=>'NV:HTTT, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2127', label_value=>'NV:HTTT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2128', label_value=>'NV:HTTT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2129', label_value=>'NV:HTTT, TGMT, MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2130', label_value=>'NV:CNPM, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2131', label_value=>'NV:CNPM, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2132', label_value=>'NV:CNPM, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2133', label_value=>'NV:CNPM, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2134', label_value=>'NV:CNPM, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2135', label_value=>'NV:CNPM, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2136', label_value=>'NV:KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2137', label_value=>'NV:KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2138', label_value=>'NV:KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2139', label_value=>'NV:CNTT, TGMT, MMT:');

--C4
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2140', label_value=>'NV:HTTT, CNPM, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2141', label_value=>'NV:HTTT, CNPM, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2142', label_value=>'NV:HTTT, CNPM, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2143', label_value=>'NV:HTTT, CNPM, CNP, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2144', label_value=>'NV:HTTT, CNPM, CNP, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2145', label_value=>'NV:HTTT, CNPM, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2146', label_value=>'NV:HTTT, KHMT, CNP, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2147', label_value=>'NV:HTTT, KHMT, CNP, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2148', label_value=>'NV:HTTT, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2149', label_value=>'NV:HTTT, CNP, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2150', label_value=>'NV:CNP, KHMT, CNP, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2151', label_value=>'NV:CNP, KHMT, CNP, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2152', label_value=>'NV:CNP, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2153', label_value=>'NV:CNP, CNP, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2154', label_value=>'NV:KHMT, CNP, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2155', label_value=>'NV:HTTT, CNPM, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2156', label_value=>'NV:HTTT, CNPM, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2157', label_value=>'NV:HTTT, CNPM, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2158', label_value=>'NV:HTTT, CNPM, CNP, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2159', label_value=>'NV:HTTT, CNPM, CNP, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2160', label_value=>'NV:HTTT, CNPM, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2161', label_value=>'NV:HTTT, KHMT, CNP, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2162', label_value=>'NV:HTTT, KHMT, CNP, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2163', label_value=>'NV:HTTT, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2164', label_value=>'NV:HTTT, CNP, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2165', label_value=>'NV:CNP, KHMT, CNP, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2166', label_value=>'NV:CNP, KHMT, CNP, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2167', label_value=>'NV:CNP, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2168', label_value=>'NV:CNP, CNP, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2169', label_value=>'NV:KHMT, CNP, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2170', label_value=>'NV:HTTT, CNPM, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2171', label_value=>'NV:HTTT, CNPM, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2172', label_value=>'NV:HTTT, CNPM, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2173', label_value=>'NV:HTTT, CNPM, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2174', label_value=>'NV:HTTT, CNPM, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2175', label_value=>'NV:HTTT, CNPM, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2176', label_value=>'NV:HTTT, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2177', label_value=>'NV:HTTT, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2178', label_value=>'NV:HTTT, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2179', label_value=>'NV:HTTT, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2180', label_value=>'NV:CNPM, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2181', label_value=>'NV:CNPM, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2182', label_value=>'NV:CNPM, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2183', label_value=>'NV:CNPM, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2184', label_value=>'NV:KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2185', label_value=>'NV:HTTT, CNPM, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2186', label_value=>'NV:HTTT, CNPM, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2187', label_value=>'NV:HTTT, CNPM, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2188', label_value=>'NV:HTTT, CNPM, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2189', label_value=>'NV:HTTT, CNPM, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2190', label_value=>'NV:HTTT, CNPM, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2191', label_value=>'NV:HTTT, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2192', label_value=>'NV:HTTT, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2193', label_value=>'NV:HTTT, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2194', label_value=>'NV:HTTT, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2195', label_value=>'NV:CNPM, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2196', label_value=>'NV:CNPM, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2197', label_value=>'NV:CNPM, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2198', label_value=>'NV:CNPM, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2199', label_value=>'NV:KHMT, CNTT, TGMT, MMT:');

--C5
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2200', label_value=>'NV:HTTT, CNPM, KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2201', label_value=>'NV:HTTT, CNPM, KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2202', label_value=>'NV:HTTT, CNPM, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2203', label_value=>'NV:HTTT, CNPM, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2204', label_value=>'NV:HTTT, KHMT, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2205', label_value=>'NV:CNPM, KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2206', label_value=>'NV:HTTT, CNPM, KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2207', label_value=>'NV:HTTT, CNPM, KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2208', label_value=>'NV:HTTT, CNPM, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2209', label_value=>'NV:HTTT, CNPM, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2210', label_value=>'NV:HTTT, KHMT, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2211', label_value=>'NV:CNPM, KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2212', label_value=>'NV:HTTT, CNPM, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2213', label_value=>'NV:HTTT, CNPM, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2214', label_value=>'NV:HTTT, CNPM, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2215', label_value=>'NV:HTTT, CNPM, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2216', label_value=>'NV:HTTT, KHMT, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2217', label_value=>'NV:CNPM, KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2218', label_value=>'NV:HTTT, CNPM, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2219', label_value=>'NV:HTTT, CNPM, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2220', label_value=>'NV:HTTT, CNPM, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2221', label_value=>'NV:HTTT, CNPM, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2222', label_value=>'NV:HTTT, KHMT, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2223', label_value=>'NV:CNPM, KHMT, CNTT, TGMT, MMT:');

--C6
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2224', label_value=>'NV:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2225', label_value=>'NV:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2226', label_value=>'NV:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'2227', label_value=>'NV:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:');

--SV
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'600', label_value=>'SV::');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'610', label_value=>'SV:HTTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'620', label_value=>'SV:CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'630', label_value=>'SV:KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'640', label_value=>'SV:CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'650', label_value=>'SV:TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'660', label_value=>'SV:MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'601', label_value=>'SV::CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'602', label_value=>'SV::CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'603', label_value=>'SV::CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'611', label_value=>'SV:HTTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'621', label_value=>'SV:CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'631', label_value=>'SV:KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'641', label_value=>'SV:CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'651', label_value=>'SV:TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'661', label_value=>'SV:MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'612', label_value=>'SV:HTTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'622', label_value=>'SV:CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'632', label_value=>'SV:KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'642', label_value=>'SV:CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'652', label_value=>'SV:TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'662', label_value=>'SV:MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'663', label_value=>'SV:HTTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'664', label_value=>'SV:CNPM:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'665', label_value=>'SV:KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'666', label_value=>'SV:CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'667', label_value=>'SV:TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'668', label_value=>'SV:MMT:CS1, CS2');

--C2
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3000', label_value=>'SV:HTTT,CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3001', label_value=>'SV:HTTT,KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3002', label_value=>'SV:HTTT,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3003', label_value=>'SV:HTTT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3004', label_value=>'SV:HTTT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3005', label_value=>'SV:CNPM,KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3006', label_value=>'SV:CNPM,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3007', label_value=>'SV:CNPM,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3008', label_value=>'SV:CNPM,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3009', label_value=>'SV:KHMT,CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3010', label_value=>'SV:KHMT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3011', label_value=>'SV:KHMT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3012', label_value=>'SV:CNTT,TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3013', label_value=>'SV:CNTT,MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3014', label_value=>'SV:TGMT,MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3015', label_value=>'SV:HTTT,CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3016', label_value=>'SV:HTTT,KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3017', label_value=>'SV:HTTT,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3018', label_value=>'SV:HTTT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3019', label_value=>'SV:HTTT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3020', label_value=>'SV:CNPM,KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3021', label_value=>'SV:CNPM,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3022', label_value=>'SV:CNPM,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3023', label_value=>'SV:CNPM,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3024', label_value=>'SV:KHMT,CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3025', label_value=>'SV:KHMT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3026', label_value=>'SV:KHMT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3027', label_value=>'SV:CNTT,TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3028', label_value=>'SV:CNTT,MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3029', label_value=>'SV:TGMT,MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3030', label_value=>'SV:HTTT,CNPM:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3031', label_value=>'SV:HTTT,KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3032', label_value=>'SV:HTTT,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3033', label_value=>'SV:HTTT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3034', label_value=>'SV:HTTT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3035', label_value=>'SV:CNPM,KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3036', label_value=>'SV:CNPM,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3037', label_value=>'SV:CNPM,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3038', label_value=>'SV:CNPM,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3039', label_value=>'SV:KHMT,CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3040', label_value=>'SV:KHMT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3041', label_value=>'SV:KHMT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3042', label_value=>'SV:CNTT,TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3043', label_value=>'SV:CNTT,MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3044', label_value=>'SV:TGMT,MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3045', label_value=>'SV:HTTT,CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3046', label_value=>'SV:HTTT,KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3047', label_value=>'SV:HTTT,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3048', label_value=>'SV:HTTT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3049', label_value=>'SV:HTTT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3050', label_value=>'SV:CNPM,KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3051', label_value=>'SV:CNPM,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3052', label_value=>'SV:CNPM,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3053', label_value=>'SV:CNPM,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3054', label_value=>'SV:KHMT,CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3055', label_value=>'SV:KHMT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3056', label_value=>'SV:KHMT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3057', label_value=>'SV:CNTT,TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3058', label_value=>'SV:CNTT,MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3059', label_value=>'SV:TGMT,MMT:');

--C3
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3060', label_value=>'NV:HTTT, CNPM, KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3061', label_value=>'NV:HTTT, CNPM, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3062', label_value=>'NV:HTTT, CNPM, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3063', label_value=>'NV:HTTT, CNPM, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3064', label_value=>'NV:HTTT, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3065', label_value=>'NV:HTTT, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3066', label_value=>'NV:HTTT, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3067', label_value=>'NV:HTTT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3068', label_value=>'NV:HTTT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3069', label_value=>'NV:HTTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3070', label_value=>'NV:CNPM, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3071', label_value=>'NV:CNPM, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3072', label_value=>'NV:CNPM, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3073', label_value=>'NV:CNPM, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3074', label_value=>'NV:CNPM, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3075', label_value=>'NV:CNPM, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3076', label_value=>'NV:KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3077', label_value=>'NV:KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3078', label_value=>'NV:KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3079', label_value=>'NV:CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3080', label_value=>'NV:HTTT, CNPM, KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3081', label_value=>'NV:HTTT, CNPM, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3082', label_value=>'NV:HTTT, CNPM, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3083', label_value=>'NV:HTTT, CNPM, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3084', label_value=>'NV:HTTT, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3085', label_value=>'NV:HTTT, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3086', label_value=>'NV:HTTT, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3087', label_value=>'NV:HTTT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3088', label_value=>'NV:HTTT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3089', label_value=>'NV:HTTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3090', label_value=>'NV:CNPM, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3091', label_value=>'NV:CNPM, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3092', label_value=>'NV:CNPM, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3093', label_value=>'NV:CNPM, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3094', label_value=>'NV:CNPM, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3095', label_value=>'NV:CNPM, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3096', label_value=>'NV:KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3097', label_value=>'NV:KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3098', label_value=>'NV:KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3099', label_value=>'NV:CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3100', label_value=>'SV:HTTT, CNPM, KHMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3101', label_value=>'SV:HTTT, CNPM, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3102', label_value=>'SV:HTTT, CNPM, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3103', label_value=>'SV:HTTT, CNPM, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3104', label_value=>'SV:HTTT, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3105', label_value=>'SV:HTTT, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3106', label_value=>'SV:HTTT, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3107', label_value=>'SV:HTTT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3108', label_value=>'SV:HTTT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3109', label_value=>'SV:HTTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3110', label_value=>'SV:CNPM, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3111', label_value=>'SV:CNPM, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3112', label_value=>'SV:CNPM, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3113', label_value=>'SV:CNPM, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3114', label_value=>'SV:CNPM, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3115', label_value=>'SV:CNPM, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3116', label_value=>'SV:KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3117', label_value=>'SV:KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3118', label_value=>'SV:KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3119', label_value=>'SV:CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3120', label_value=>'SV:HTTT, CNPM, KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3121', label_value=>'SV:HTTT, CNPM, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3122', label_value=>'SV:HTTT, CNPM, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3123', label_value=>'SV:HTTT, CNPM, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3124', label_value=>'SV:HTTT, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3125', label_value=>'SV:HTTT, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3126', label_value=>'SV:HTTT, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3127', label_value=>'SV:HTTT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3128', label_value=>'SV:HTTT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3129', label_value=>'SV:HTTT, TGMT, MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3130', label_value=>'SV:CNPM, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3131', label_value=>'SV:CNPM, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3132', label_value=>'SV:CNPM, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3133', label_value=>'SV:CNPM, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3134', label_value=>'SV:CNPM, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3135', label_value=>'SV:CNPM, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3136', label_value=>'SV:KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3137', label_value=>'SV:KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3138', label_value=>'SV:KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3139', label_value=>'SV:CNTT, TGMT, MMT:');

--C4
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3140', label_value=>'SV:HTTT, CNPM, KHMT, CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3141', label_value=>'SV:HTTT, CNPM, KHMT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3142', label_value=>'SV:HTTT, CNPM, KHMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3143', label_value=>'SV:HTTT, CNPM, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3144', label_value=>'SV:HTTT, CNPM, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3145', label_value=>'SV:HTTT, CNPM, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3146', label_value=>'SV:HTTT, KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3147', label_value=>'SV:HTTT, KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3148', label_value=>'SV:HTTT, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3149', label_value=>'SV:HTTT, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3150', label_value=>'SV:CNPM, KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3151', label_value=>'SV:CNPM, KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3152', label_value=>'SV:CNPM, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3153', label_value=>'SV:CNPM, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3154', label_value=>'SV:KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3155', label_value=>'SV:HTTT, CNPM, KHMT, CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3156', label_value=>'SV:HTTT, CNPM, KHMT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3157', label_value=>'SV:HTTT, CNPM, KHMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3158', label_value=>'SV:HTTT, CNPM, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3159', label_value=>'SV:HTTT, CNPM, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3160', label_value=>'SV:HTTT, CNPM, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3161', label_value=>'SV:HTTT, KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3162', label_value=>'SV:HTTT, KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3163', label_value=>'SV:HTTT, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3164', label_value=>'SV:HTTT, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3165', label_value=>'SV:CNPM, KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3166', label_value=>'SV:CNPM, KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3167', label_value=>'SV:CNPM, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3168', label_value=>'SV:CNPM, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3169', label_value=>'SV:KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3170', label_value=>'SV:HTTT, CNPM, KHMT, CNTT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3171', label_value=>'SV:HTTT, CNPM, KHMT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3172', label_value=>'SV:HTTT, CNPM, KHMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3173', label_value=>'SV:HTTT, CNPM, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3174', label_value=>'SV:HTTT, CNPM, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3175', label_value=>'SV:HTTT, CNPM, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3176', label_value=>'SV:HTTT, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3177', label_value=>'SV:HTTT, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3178', label_value=>'SV:HTTT, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3179', label_value=>'SV:HTTT, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3180', label_value=>'SV:CNPM, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3181', label_value=>'SV:CNPM, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3182', label_value=>'SV:CNPM, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3183', label_value=>'SV:CNPM, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3184', label_value=>'SV:KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3185', label_value=>'SV:HTTT, CNPM, KHMT, CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3186', label_value=>'SV:HTTT, CNPM, KHMT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3187', label_value=>'SV:HTTT, CNPM, KHMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3188', label_value=>'SV:HTTT, CNPM, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3189', label_value=>'SV:HTTT, CNPM, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3190', label_value=>'SV:HTTT, CNPM, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3191', label_value=>'SV:HTTT, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3192', label_value=>'SV:HTTT, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3193', label_value=>'SV:HTTT, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3194', label_value=>'SV:HTTT, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3195', label_value=>'SV:CNPM, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3196', label_value=>'SV:CNPM, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3197', label_value=>'SV:CNPM, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3198', label_value=>'SV:CNPM, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3199', label_value=>'SV:KHMT, CNTT, TGMT, MMT:');

--C5
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3200', label_value=>'SV:HTTT, CNPM, KHMT, CNTT, TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3201', label_value=>'SV:HTTT, CNPM, KHMT, CNTT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3202', label_value=>'SV:HTTT, CNPM, KHMT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3203', label_value=>'SV:HTTT, CNPM, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3204', label_value=>'SV:HTTT, KHMT, CNTT, TGMT, MMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3205', label_value=>'SV:CNPM, KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3206', label_value=>'SV:HTTT, CNPM, KHMT, CNTT, TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3207', label_value=>'SV:HTTT, CNPM, KHMT, CNTT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3208', label_value=>'SV:HTTT, CNPM, KHMT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3209', label_value=>'SV:HTTT, CNPM, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3210', label_value=>'SV:HTTT, KHMT, CNTT, TGMT, MMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3211', label_value=>'SV:CNPM, KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3212', label_value=>'SV:HTTT, CNPM, KHMT, CNTT, TGMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3213', label_value=>'SV:HTTT, CNPM, KHMT, CNTT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3214', label_value=>'SV:HTTT, CNPM, KHMT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3215', label_value=>'SV:HTTT, CNPM, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3216', label_value=>'SV:HTTT, KHMT, CNTT, TGMT, MMT:CS1, CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3217', label_value=>'SV:CNPM, KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3218', label_value=>'SV:HTTT, CNPM, KHMT, CNTT, TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3219', label_value=>'SV:HTTT, CNPM, KHMT, CNTT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3220', label_value=>'SV:HTTT, CNPM, KHMT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3221', label_value=>'SV:HTTT, CNPM, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3222', label_value=>'SV:HTTT, KHMT, CNTT, TGMT, MMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3223', label_value=>'SV:CNPM, KHMT, CNTT, TGMT, MMT:');

--C6
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3224', label_value=>'SV:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3225', label_value=>'SV:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3226', label_value=>'SV:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:CS1, CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'3227', label_value=>'SV:HTTT, CNPM, KHMT, CNTT, TGMT, MMT:');
