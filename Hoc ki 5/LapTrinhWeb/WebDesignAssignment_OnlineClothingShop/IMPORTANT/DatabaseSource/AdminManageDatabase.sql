USE [OnlineClothingShop]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/30/2023 8:05:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 10/30/2023 8:05:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 10/30/2023 8:05:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 10/30/2023 8:05:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 10/30/2023 8:05:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 10/30/2023 8:05:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 10/30/2023 8:05:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 10/30/2023 8:05:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231029153251_Data', N'6.0.24')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231029155929_idetityTable', N'6.0.24')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231030000824_newUserRegis', N'6.0.24')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231030001400_newRegisCols', N'6.0.24')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'297a578b-196a-466a-b361-1946f2c5b65d', N'visitor', N'VISITOR', N'3afc406d-f3af-4cdc-a236-4e45d47f06e3')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3ec9e9a0-0d32-42e4-8534-d9a60d30b636', N'admin', N'ADMIN', N'b2a46f73-4e21-42a9-9350-bdd8ab0e1ce1')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'72ddd7d2-1fe1-42e1-a144-01a13062e22d', N'Sales', N'SALES', N'6e2ed682-4337-4d2d-9153-e3d302bd6ad4')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'77fb5d43-2198-4fef-b64d-bb5f12be115c', N'User', N'USER', N'bc56dd55-94be-4dd8-a6db-9a8e515c4711')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ead59b5f-7442-4c6c-94b0-88e1914abd79', N'quantrivien', N'QUANTRIVIEN', N'eb325cb1-fc70-460e-9405-227da43f6013')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0b894f81-b891-4172-b38e-f52117fe33da', N'3ec9e9a0-0d32-42e4-8534-d9a60d30b636')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2fa23c07-2425-4528-873c-6137c04c6411', N'3ec9e9a0-0d32-42e4-8534-d9a60d30b636')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0b358745-b4fc-45d9-b047-bdaac2941cbc', N'77fb5d43-2198-4fef-b64d-bb5f12be115c')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0ba8b84e-07bc-41a4-a561-b164b5077dca', N'77fb5d43-2198-4fef-b64d-bb5f12be115c')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'944b98b0-dd05-4581-be73-4b8683f85c4d', N'77fb5d43-2198-4fef-b64d-bb5f12be115c')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a80a487f-ee8a-40b2-bf8e-a6a8e0c99ebd', N'77fb5d43-2198-4fef-b64d-bb5f12be115c')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'0b358745-b4fc-45d9-b047-bdaac2941cbc', N'jqkat@gmail.com', N'JQKAT@GMAIL.COM', N'jqkat@gmail.com', N'JQKAT@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEMK55U9I0iRA+P0N29Vp1gFyFvBxRnlYApjIZ/iCwYWffOLQlhibkiFK3Y1dAwEeew==', N'NAMUVABT27ES4RJ5QKJYSRLWKDNXIRWP', N'cfa5b9d6-6f3a-4610-a41d-93eae6c0431a', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'dcmm', N'dcmm')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'0b894f81-b891-4172-b38e-f52117fe33da', N'nguythequang200@gmail.com', N'NGUYTHEQUANG200@GMAIL.COM', N'nguythequang200@gmail.com', N'NGUYTHEQUANG200@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAECfyCqgBRAK4JdW3qkqTyxCDxMP6IRAw53hE55c7ijKwy3OBIXdOv9nMLz/6Z9Pikw==', N'2E233JBA7WOWSPITJCZUURWSD27XORIS', N'9e218826-4d99-4485-85d3-efb00713533d', N'0965361162', 0, 0, NULL, 1, 0, N'ApplicationUser', N'Quang', N'Quang')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'0ba8b84e-07bc-41a4-a561-b164b5077dca', N'ntquan@gmail.com', N'NTQUAN@GMAIL.COM', N'ntquan@gmail.com', N'NTQUAN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEARphXuCgYJpBflRKb3/iJiM8Mrtwpr2HjZRm5S1682rVn8pOM8nLPYqwnmwRrYqSQ==', N'MSJ52P7Y3MFMSZNJJ3ULVSAHA2A6YU6Z', N'beee3bf1-f799-4793-9468-887a7403b10d', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'Quan', N'Nguyen The')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'1006a68a-7158-4d5c-9dce-2b4599d56c18', N'hahongha@gmail.com', N'HAHONGHA@GMAIL.COM', N'hahongha@gmail.com', N'HAHONGHA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEPaB6TuP5sm8kk6PIirPOep4ijV7DfopduuAcYTtrrNEsD5VsIEQ8ZJmOWCZkzYjIA==', N'ZF6Q2WB4SZSILPKIER6SYQPFCKKERYSL', N'4b064a24-b588-47b3-a34d-2658c16d3ccf', NULL, 0, 0, NULL, 1, 0, N'', N'Ha', N'Ha')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'2fa23c07-2425-4528-873c-6137c04c6411', N'admin@gmail.com', N'ADMIN@GMAIL.COM', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAENLsA+VCgXBPadgLnHDtXENT6n03a/4FyVorbyG4JYdxicAReMNwVMxx1qMtdw4xbA==', N'GROMYT635IEK6ING5YM6453WZ44QPFRZ', N'bcaf54e5-d599-4a73-8372-0aec8b5a0d6c', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'admin', N'admin')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'3975162e-41fb-4181-98fe-4857ffc5948a', N'chichi@gmail.com', N'CHICHI@GMAIL.COM', N'chichi@gmail.com', N'CHICHI@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEOmwX7N1hDAALSLSOa1KTsxYSrcUQpSCk3bFMKsRLl1bQMdkicguJc8ICKag70K3Gw==', N'IOTXWSQRMGSXCSZZSOCHBQLUIV2ZG4IU', N'f39033cf-1881-4c51-b0f2-1aaa89ee1a89', NULL, 0, 0, NULL, 1, 0, N'', NULL, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'7acaa2bd-737b-465c-bf28-7af434de24bb', N'lala@gmail.com', N'LALA@GMAIL.COM', N'lala@gmail.com', N'LALA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAENslRuZzJIbnvzPBFK8z3EHPXQZFAu/CEvZMa71bxY5bmQYzC2aymOl6yZtsgxP5kg==', N'J246FXA7G3E3CJZ4VMAYL5RHSPAOGMVV', N'da80af01-0541-4358-ac15-5c2f1dc1df99', NULL, 0, 0, NULL, 1, 0, N'', NULL, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'7fc4fdb1-73f8-447b-a951-7ab0c7878853', N'sasa@gmail.com', N'SASA@GMAIL.COM', N'sasa@gmail.com', N'SASA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEE02DkAK3eekTCVWMrgXKZEED/D8pWAKg32iqXztXuVMwWNfUixnlXrDbVVssb+LAg==', N'QYEF56XI4WOQQHXUBPH7ZLJOBQYTT4MJ', N'95f2536c-76b1-41f9-bc33-e6c002ef4297', NULL, 0, 0, NULL, 1, 0, N'', N'Sa', N'Sa')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'944b98b0-dd05-4581-be73-4b8683f85c4d', N'qwe@gmail.com', N'QWE@GMAIL.COM', N'qwe@gmail.com', N'QWE@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEFpzdEiBfBYRTjSFR6iBQAzKS4JwFQQWP1UEWjpoQohQIEsa36kE2emjJbouvQlTvw==', N'B6J5YIP7JNWKLZ4F4XMPNNX54TAHWHS7', N'b3f137f0-1ac0-4cf9-a711-cae42c4b11a5', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'12', N'2wq')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'a80a487f-ee8a-40b2-bf8e-a6a8e0c99ebd', N'user0@gmail.com', N'USER0@GMAIL.COM', N'user0@gmail.com', N'USER0@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEIWkuN952HzyJqxLJudwFZX8RbEMOr15EG9UxeqoLRd1vT6oLDwLcrHp25HoqN5ITQ==', N'KA72LTT7EZIRSS2ORJY2ANTYNEGH2I5L', N'bfdd5460-7372-4081-982b-1a3e544e7593', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'user0', N'user0')
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (N'') FOR [Discriminator]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
