/*
Navicat MySQL Data Transfer

Source Server         : DBGleidson
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : ramais

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2019-05-31 09:40:08
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `lista`
-- ----------------------------
DROP TABLE IF EXISTS `lista`;
CREATE TABLE `lista` (
  `Code` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) DEFAULT NULL,
  `ramal` int(11) DEFAULT NULL,
  `departamento` varchar(10) DEFAULT NULL,
  `torre` varchar(10) DEFAULT NULL,
  `email` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Code`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of lista
-- ----------------------------
INSERT INTO `lista` VALUES ('2', 'Washington', '9540', 'NIT', 'Torre C', 'washington@imap.com');
INSERT INTO `lista` VALUES ('3', 'Carlos E.Tudo Otimo', '9524', 'NIT', 'Torre C', 'tudotimo@email.com');
INSERT INTO `lista` VALUES ('12', 'Gleidson', '9540', 'NIT', 'Torre C', 'gl@.com');
INSERT INTO `lista` VALUES ('13', 'Simone', '9522', 'APAF', 'A', 'f@f.com');
INSERT INTO `lista` VALUES ('14', 'Adelaide', '9547', 'APAF', 'Torre B', 'f@f.com');
INSERT INTO `lista` VALUES ('15', 'Cintia ', '9591', 'EAP', 'Torre B', 'f@f.com');

-- ----------------------------
-- Table structure for `user_login`
-- ----------------------------
DROP TABLE IF EXISTS `user_login`;
CREATE TABLE `user_login` (
  `login` varchar(20) NOT NULL,
  `senha` varchar(8) NOT NULL,
  `id_user` int(5) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of user_login
-- ----------------------------
INSERT INTO `user_login` VALUES ('admin', 'admin', '1');
