using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sagep.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Subject = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int[]>(type: "integer[]", nullable: true),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ApiKey = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NomeExibicao = table.Column<string>(type: "text", nullable: true),
                    OficioLeituraAssinaturaNome = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    OficioLeituraAssinaturaCargo = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    OficioLeituraAssinaturaMatricula = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    OficioLeituraVocativo1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    OficioLeituraVocativo2 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    OficioLeituraVocativo3 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    EnderecoLogradouro = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    EnderecoLogradouroNumero = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    EnderecoBairro = table.Column<string>(type: "text", nullable: true),
                    EnderecoCEP = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    EnderecoCidade = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    EnderecoEstado = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    TelefoneDDD = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: true),
                    TelefoneNumero = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: true),
                    EmailPrincipal = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VerticalNavItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    Path = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Action = table.Column<string>(type: "text", nullable: true),
                    Subject = table.Column<string>(type: "text", nullable: true),
                    Disabled = table.Column<bool>(type: "boolean", nullable: false),
                    BadgeContent = table.Column<string>(type: "text", nullable: true),
                    ExternalLink = table.Column<bool>(type: "boolean", nullable: false),
                    OpenInNewTab = table.Column<bool>(type: "boolean", nullable: false),
                    BadgeColor = table.Column<string>(type: "text", nullable: true),
                    SectionTitle = table.Column<string>(type: "text", nullable: true),
                    Position = table.Column<int>(type: "integer", nullable: false),
                    LevelMeKey = table.Column<Guid>(type: "uuid", nullable: false),
                    LevelUpKey = table.Column<Guid>(type: "uuid", nullable: false),
                    VerticalNavItemId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerticalNavItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VerticalNavItems_VerticalNavItems_VerticalNavItemId",
                        column: x => x.VerticalNavItemId,
                        principalTable: "VerticalNavItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    UniqueKey = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    TenantId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetGroups_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Avatar = table.Column<string>(type: "text", nullable: true),
                    Setor = table.Column<int>(type: "integer", nullable: false),
                    Funcao = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: true),
                    DataAniversario = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    TelefoneCelular = table.Column<long>(type: "bigint", maxLength: 20, nullable: false, defaultValue: 99999999999L),
                    Genero = table.Column<int>(type: "integer", nullable: false),
                    TenantId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleGroups",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleGroups", x => new { x.RoleId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_AspNetRoleGroups_AspNetGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "AspNetGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetRoleGroups_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationNotifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Scope = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    SenderUser = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    IsRead = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    MessageTitle = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    MessageBody = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MessageLabel = table.Column<string>(type: "text", nullable: true),
                    MessageLabelColor = table.Column<string>(type: "text", nullable: true),
                    MessageDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    TenantId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationNotifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationNotifications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_ApplicationNotifications_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserGroups",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserGroups", x => new { x.UserId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_AspNetUserGroups_AspNetGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "AspNetGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUserGroups_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Actions", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "Subject" },
                values: new object[,]
                {
                    { "0179357a-4cef-4fe7-b470-89f95ba8412b", new[] { 5 }, "43be1f40-e532-4757-9ed5-fd00b14358ed", "Pode deletar um contrato de cliente", "CanClienteContratoDelete", "CANCLIENTECONTRATODELETE", "ac-clienteContrato-page" },
                    { "0353aa6f-c251-4e5a-a74c-ef8933904f77", new[] { 2 }, "c942eaf5-4c68-4842-8f92-bd38908a1fd9", "Pode listar os dados de um contrato vinculado a um vendedor", "CanVendedorContratoRead", "CANVENDEDORCONTRATOREAD", "ac-vendedorContrato-page" },
                    { "0605f798-8a49-43db-b71b-6d57b8cd5e08", new[] { 2 }, "aff3ff6d-085e-4049-b399-29b905611d48", "Pode listar os dados de uma rotina", "CanRotinaRead", "CANROTINAREAD", "ac-rotina-page" },
                    { "07c58b99-3541-4485-ac53-c296bcd17060", new[] { 1, 2, 3, 4, 5 }, "0b163d3f-0cc3-47ba-a782-82a7d480db51", "Pode realizar todas as ações/operações em todos os produtos", "CanProdutoAll", "CANPRODUTOALL", "ac-produto-page" },
                    { "07cc33b6-adfc-4f2b-8368-e84e8f34d984", new[] { 5 }, "d7148354-a284-4d86-879d-8a7848840a04", "Pode deletar um vendedor", "CanVendedorDelete", "CANVENDEDORDELETE", "ac-vendedor-page" },
                    { "080ab080-74d3-44a2-8816-9541022205bc", new[] { 1, 2, 3, 4, 5 }, "a9a72bbe-c90d-458b-84a6-70ef59984b0f", "Pode visualizar todas as dashboards do cliente", "CanDashboardClienteAll", "CANDASHBOARDCLIENTEALL", "ac-dashboardCliente-page" },
                    { "0931f9df-3673-4073-b71f-fcca992b4bfb", new[] { 2 }, "454380ed-51ac-4a78-8910-b8fc3fe593ca", "Pode listar os dados de uma comissão de vendedor", "CanVendedorComissaoRead", "CANVENDEDORCOMISSAOREAD", "ac-vendedorComissao-page" },
                    { "09767577-6c94-4c62-8364-cc75f33554bd", new[] { 2 }, "d0cb01d0-6626-4f9c-bb51-4996b1e55beb", "Pode listar os dados de todas as chaves de api de terceiro", "CanChaveApiTerceiroRead", "CANCHAVEAPITERCEIROREAD", "ac-chaveApiTerceiro-page" },
                    { "0a4f1564-159b-4f4d-badd-f5ce181a5b86", new[] { 1 }, "e83db08b-8696-466f-b95b-2927490b48ca", "CanDashboardPublicaClienteContratoList", "CanDashboardPublicaClienteContratoList", "CANDASHBOARDPUBLICACLIENTECONTRATOLIST", "ac-dashboardPublicaClienteContrato-page" },
                    { "0c703371-16df-4a3d-ab3a-6776e0cc5476", new[] { 4 }, "35520ad0-4663-4168-bdbc-5c090b64284b", "Pode atualizar um fornecedor", "CanFornecedorUpdate", "CANFORNECEDORUPDATE", "ac-fornecedor-page" },
                    { "0e13d4e2-5858-4c63-a2f0-779974eb6e5e", new[] { 3 }, "c22f9b25-e695-4e8b-bad3-8d774e83f368", "Pode visualizar um contrato vinculado a um ou vários vendedores", "CanVendedorContratoCreate", "CANVENDEDORCONTRATOCREATE", "ac-vendedorContrato-page" },
                    { "0ea51ca8-ccb7-4578-ab89-33413b44a7aa", new[] { 1, 2, 3, 4, 5 }, "01d24fb9-51ee-4203-a6a8-b2180c3868dc", "Pode realizar todas as ações/operações em todos os produtos de fornecedores", "CanFornecedorProdutoAll", "CANFORNECEDORPRODUTOALL", "ac-fornecedorProduto-page" },
                    { "0fdd5d6d-6f81-4f48-805f-f7d78dc64618", new[] { 4 }, "19e41b17-d12c-4eea-b00d-fb89e1e8fa4c", "Pode criar uma comissão de vendedor", "CanVendedorComissaoUpdate", "CANVENDEDORCOMISSAOUPDATE", "ac-vendedorComissao-page" },
                    { "11ea61da-45d5-4809-a047-1e3f310a5e51", new[] { 4 }, "f2ffee85-2c14-4f1e-b197-d3b3d20a7b08", "Pode atualizar os dados de um cliente", "CanClienteUpdate", "CANCLIENTEUPDATE", "ac-cliente-page" },
                    { "13d766f8-6058-4736-b691-2fd0a686761f", new[] { 1, 2, 3, 4, 5 }, "1f45e244-3cce-4eaa-81b8-09fa197934a1", "Pode realizar todas as ações/operações em todos os grupos", "CanGroupAll", "CANGROUPALL", "ac-group-page" },
                    { "15597aa7-449a-42f9-9e9e-a2f14aac77ac", new[] { 3 }, "c583ed89-e6b6-4e6f-b987-9db5a039683b", "Pode visualizar um produto de fornecedor", "CanFornecedorProdutoCreate", "CANFORNECEDORPRODUTOCREATE", "ac-fornecedorProduto-page" },
                    { "1af46fbf-57de-4ac2-a64d-77f5c04db6c3", new[] { 3 }, "615d0446-629c-48e9-92bc-f2a40ff73b12", "Pode criar um produto de cliente", "CanClienteProdutoCreate", "CANCLIENTEPRODUTOCREATE", "ac-clienteProduto-page" },
                    { "1beda096-7932-4470-9898-32175c3635e9", new[] { 4 }, "85a0481d-cc86-4080-bc93-53fb1d9840bb", "Pode atualizar os dados de um grupo", "CanGroupUpdate", "CANGROUPUPDATE", "ac-group-page" },
                    { "1bfb2043-1a06-431d-94fd-d5c20815ae23", new[] { 5 }, "46192ec1-76ba-452f-bbd0-eb77b983e06d", "Pode deletar um pipeline", "CanPipelineDelete", "CANPIPELINEDELETE", "ac-pipeline-page" },
                    { "1d6eea0b-03ff-4f9a-bd23-57087cdf801f", new[] { 4 }, "a4a9cc6b-7469-4d38-8c1d-c70444630976", "Pode atualizar um serviço de um cliente", "CanClienteServicoUpdate", "CANCLIENTESERVICOUPDATE", "ac-clienteServico-page" },
                    { "1e6e1f34-5145-494a-802c-8b9ae12e14bc", new[] { 3 }, "d7a8e5f2-67c6-48f8-a83f-e1e14d409c3c", "Pode criar um pipeline", "CanPipelineCreate", "CANPIPELINECREATE", "ac-pipeline-page" },
                    { "1facdce1-3ebe-4142-97e5-f107eda3e274", new[] { 4 }, "0e19c117-05c5-46e2-ae86-c8df211de27e", "Pode atualizar um serviço de um fornecedor", "CanFornecedorServicoUpdate", "CANFORNECEDORSERVICOUPDATE", "ac-fornecedorServico-page" },
                    { "23a38028-8ebb-447e-b9bc-fdf56da09863", new[] { 1 }, "482ca4bc-1da6-4f61-9b0f-528ec587585c", "Pode listar os dados de todos os produtos de clientes", "CanClienteProdutoList", "CANCLIENTEPRODUTOLIST", "ac-clienteProduto-page" },
                    { "278b2bc2-69e1-48fa-b64a-a62bdee353a8", new[] { 2 }, "6a930a0c-1910-40f7-a971-eec30b0c1c81", "Pode listar os dados de um produtos", "CanProdutoRead", "CANPRODUTOREAD", "ac-produto-page" },
                    { "2936fd4d-14e5-433b-b61e-3a51d003bea2", new[] { 5 }, "bfd6c288-1322-4376-9399-9f8c87de91b5", "Pode deletar um cliente", "CanClienteDelete", "CANCLIENTEDELETE", "ac-cliente-page" },
                    { "299faf71-3172-4f5b-8b81-1870afbcb882", new[] { 5 }, "136ff6a0-d4eb-481f-8dfd-7728f41e5b5e", "Pode deletar um vínculo de contrato com um vendedor", "CanVendedorContratoDelete", "CANVENDEDORCONTRATODELETE", "ac-vendedorContrato-page" },
                    { "2b40ff56-bf43-40a9-868d-2b7d976a5fc1", new[] { 3 }, "1817b5b7-7a8d-4ab3-90bc-d6093751310d", "Pode criar um usuário", "CanUserCreate", "CANUSERCREATE", "ac-user-page" },
                    { "2cc5d905-2e85-43c7-a8a8-bc8e4e24d79a", new[] { 1 }, "f4ba2c94-4374-4ece-887a-9a503bff9f0c", "Pode listar os dados de todos os contratos de clientes", "CanClienteContratoList", "CANCLIENTECONTRATOLIST", "ac-clienteContrato-page" },
                    { "30f7664f-a6da-4f59-9f5d-1ed94d54d520", new[] { 1 }, "25720251-b222-488b-b13c-7cb78ea939f7", "Pode listar os dados de comissão de vendedores", "CanVendedorComissaoList", "CANVENDEDORCOMISSAOLIST", "ac-vendedorComissao-page" },
                    { "32cbb415-ff31-42b7-9490-98c00d293000", new[] { 1 }, "d7f2c286-b09b-4d56-959a-792d8185290b", "Pode listar os dados de todos os usuários", "CanUserList", "CANUSERLIST", "ac-user-page" },
                    { "347ff9ef-13b2-4f23-895f-eac7f1cc2a43", new[] { 3 }, "12b20c2b-22ee-480b-9486-d7b46623df91", "Pode criar uma role/permissão", "CanRoleCreate", "CANROLECREATE", "ac-role-page" },
                    { "35dbd113-ae96-4180-ad4d-5f8e123fa6fa", new[] { 1, 2, 3, 4, 5 }, "73a6f7e1-6717-4326-8957-a97709358028", "Pode realizar todas as ações/operações em todos os usuários", "CanUserAll", "CANUSERALL", "ac-user-page" },
                    { "371fb750-a5e1-4414-b668-ed704180d972", new[] { 1 }, "68e6445b-7e10-4d9c-b973-55135b4fc696", "CanDashboardComercialClienteContratoList", "CanDashboardComercialClienteContratoList", "CANDASHBOARDCOMERCIALCLIENTECONTRATOLIST", "ac-dashboardComercialClienteContrato-page" },
                    { "3743d42e-ed01-4f9a-9a93-0ae6bad5b77f", new[] { 1, 2, 3, 4, 5 }, "a6b2791f-ecf4-4ebb-8eb1-5a2494f6a10f", "Pode realizar todas as ações/operações em todos as roles/permissões", "CanRoleAll", "CANROLEALL", "ac-role-page" },
                    { "3863dc8f-e59d-4565-a35c-6f3ec3e09bfd", new[] { 1, 2, 3, 4, 5 }, "af095993-1403-40cf-b9a7-b29795569719", "Pode realizar todas as ações/operações em todos os contratos de clientes", "CanClienteContratoAll", "CANCLIENTECONTRATOALL", "ac-clienteContrato-page" },
                    { "3acdfb7a-21ca-45fd-b872-7cc24210f8ff", new[] { 5 }, "cdd62684-cb8c-4b99-be07-bbd3868f4d80", "Pode deletar um serviço", "CanServicoDelete", "CANSERVICODELETE", "ac-servico-page" },
                    { "3dd6281b-925f-4d67-a93d-11923d71ee0e", new[] { 4 }, "e947e454-76b2-43d4-9ec3-91eea1c952ea", "Pode atualizar um produto de cliente", "CanClienteProdutoUpdate", "CANCLIENTEPRODUTOUPDATE", "ac-clienteProduto-page" },
                    { "418ee2f7-95fb-4638-acb2-ef4367b85112", new[] { 5 }, "a2a08b33-1e68-4f2a-9517-7fe49627308b", "Pode deletar um produto de cliente", "CanClienteProdutoDelete", "CANCLIENTEPRODUTODELETE", "ac-clienteProduto-page" },
                    { "434c1963-7d5e-4545-ade4-445ed5cf40db", new[] { 4 }, "c334e83b-3f93-4e2b-a5b9-f992d3489d45", "Pode atualizar um contrato de cliente", "CanClienteContratoUpdate", "CANCLIENTECONTRATOUPDATE", "ac-clienteContrato-page" },
                    { "43d65165-4e77-4c8a-a88a-87a6b12f534b", new[] { 1 }, "3d749027-ae01-4781-8f4a-ec3c5046a529", "Pode listar os dados de todos os serviços", "CanServicoList", "CANSERVICOLIST", "ac-servico-page" },
                    { "49cd5976-8e60-4de9-ab42-f94a4746b824", new[] { 4 }, "55fd5ad7-410e-46c2-b8e7-cf028e0165f8", "Pode criar um vendedor", "CanVendedorUpdate", "CANVENDEDORUPDATE", "ac-vendedor-page" },
                    { "4af1b72d-9650-4a24-a23f-f718a71c88b7", new[] { 2 }, "f5a75a1b-e326-4528-b696-8f848e98fd21", "Pode listar os dado de um serviço de fornecedor", "CanFornecedorServicoRead", "CANFORNECEDORSERVICOREAD", "ac-fornecedorServico-page" },
                    { "4e572975-6881-4671-b339-20e3b54c0306", new[] { 1 }, "9167c84d-a5f5-46c5-b471-5052c9a2343f", "Pode listar todas as rotinas de sistema", "CanRotinaList", "CANROTINALIST", "ac-rotina-page" },
                    { "535452b1-abc9-4d6a-af78-423e7414468c", new[] { 1, 2, 3, 4, 5 }, "47f1e491-d8a7-4e3a-80bb-e840f33d3dae", "Pode visualizar todas as dashboards de controle de acesso", "CanDashboardControleAcessoAll", "CANDASHBOARDCONTROLEACESSOALL", "ac-dashboardControleAcesso-page" },
                    { "54795bfc-36d1-4fb6-be57-181003a89496", new[] { 2 }, "f6ab3e63-ec54-4cce-bc93-741e898d0aa3", "Pode listar os dados de um pipeline", "CanPipelineRead", "CANPIPELINEREAD", "ac-pipeline-page" },
                    { "550290ad-a335-41f0-af2e-ae6070a7a19f", new[] { 5 }, "ca35c4e5-76e5-42a2-8d28-8deb65873049", "Pode deletar um serviço de um fornecedor", "CanFornecedorServicoDelete", "CANFORNECEDORSERVICODELETE", "ac-fornecedorServico-page" },
                    { "58a17501-b6e7-4f5c-a4e6-06250e82ae9f", new[] { 4 }, "9140a188-9aeb-4b0a-9419-8112cbc0ea9c", "Pode atualizar um produtos", "CanProdutoUpdate", "CANPRODUTOUPDATE", "ac-produto-page" },
                    { "58fbef7a-ee1d-49e7-9ebc-696e68359b61", new[] { 5 }, "27f21d24-6b92-4af6-9d81-a3bc8f445db4", "Pode deletar um grupo", "CanGroupDelete", "CANGROUPDELETE", "ac-group-page" },
                    { "5a7611ad-e74c-49e8-8623-c3597c74f0b3", new[] { 1, 2, 3, 4, 5 }, "2dec7d0f-4c42-4d1d-b328-7a46406d0ab1", "Pode realizar todas as ações/operações em todos os serviços de fornecedores", "CanFornecedorServicoAll", "CANFORNECEDORSERVICOALL", "ac-fornecedorServico-page" },
                    { "5ebf7cc1-2758-486a-8664-b70ab92673e9", new[] { 3 }, "939f69cf-84d1-4be2-9b96-ef975adc5793", "Pode listar os dados de todas as chaves de api de terceiro", "CanChaveApiTerceiroCreate", "CANCHAVEAPITERCEIROCREATE", "ac-chaveApiTerceiro-page" },
                    { "6002fd3e-25cf-4b14-852a-b23dc0632f4a", new[] { 1 }, "517c61a8-cc00-4543-a9fc-b56f997edc1b", "Pode listar os dados de todos os grupos", "CanGroupList", "CANGROUPLIST", "ac-group-page" },
                    { "6389b3ee-7201-4ae2-a25d-fda06a1a2133", new[] { 4 }, "35720d0b-697b-4854-9a69-d26bb6f8e3f6", "Pode atualizar um pipeline", "CanPipelineUpdate", "CANPIPELINEUPDATE", "ac-pipeline-page" },
                    { "68adee0f-c803-421d-8526-24c3840180b5", new[] { 4 }, "c3947aa5-4590-4e37-843b-b48c8955ebd5", "Pode atualizar os dados de um usuário", "CanUserUpdate", "CANUSERUPDATE", "ac-user-page" },
                    { "6b5ed0a2-53c8-4957-9f4f-a2e46b535ed3", new[] { 3 }, "9bd94ca2-4712-473d-9b05-8e62cc6ceb72", "Pode criar um produtos", "CanProdutoCreate", "CANPRODUTOCREATE", "ac-produto-page" },
                    { "6be47053-0c89-4071-804f-02eedaadf9f2", new[] { 1, 2, 3, 4, 5 }, "cbdabd7a-63f9-4f81-8673-2e55854284b8", "Pode realizar todas as ações/operações em todos os pipelines", "CanPipelineAll", "CANPIPELINEALL", "ac-pipeline-page" },
                    { "6e81171c-750e-4984-ac49-525f907cfb6a", new[] { 1 }, "044ffe17-4774-4bee-bfec-7fa554746c1f", "Pode listar o título do sistema", "CanTitleSystemList", "CANTITLESYSTEMLIST", "ac-titleSystem-page" },
                    { "6ee0874b-a22a-4684-9823-079d34cefbec", new[] { 2 }, "5c5f40e7-2e75-4028-a67e-a0887b4e11c4", "Pode listar os dados de uma roles/permissão", "CanRoleRead", "CANROLEREAD", "ac-role-page" },
                    { "70e60ad2-e0f5-478b-ab32-ec5971c2daef", new[] { 1, 2, 3, 4, 5 }, "95c0135b-11bc-4f95-9c3c-128294d8bad6", "Pode realizar todas as ações/operações em todas as dashboards", "CanDashboardAll", "CANDASHBOARDALL", "ac-dashboard-page" },
                    { "78d5963b-661c-46e7-afae-79e91fafb80b", new[] { 2 }, "31b96f70-4984-4d38-919d-8ffc7c8469b4", "Pode listar os dado de um serviço de cliente", "CanClienteServicoRead", "CANCLIENTESERVICOREAD", "ac-clienteServico-page" },
                    { "7994df4e-c691-496a-8535-41175189f492", new[] { 1, 2, 3, 4, 5 }, "69ba1684-e965-487e-8174-81b449adbe0c", "Pode realizar todas as ações/operações em todos os serviços de clientes", "CanClienteServicoAll", "CANCLIENTESERVICOALL", "ac-clienteServico-page" },
                    { "799e79ca-ea94-48e9-a7f1-d7a8584af5e3", new[] { 3 }, "3bcf3bbc-35ad-413b-b938-c5752ab80e0b", "Pode visualizar uma fatura de contrato de cliente", "CanClienteContratoFaturaCreate", "CANCLIENTECONTRATOFATURACREATE", "ac-clienteContratoFatura-page" },
                    { "7a486cf1-ab2e-4042-a4e5-a38e8a4bdc0e", new[] { 5 }, "a4d74618-b3fd-4b0c-8027-335924582eca", "Pode deletar uma fatura de contrato de cliente", "CanClienteContratoFaturaDelete", "CANCLIENTECONTRATOFATURADELETE", "ac-clienteContratoFatura-page" },
                    { "7b9b17e3-067e-4236-be45-764308296ad7", new[] { 1, 2, 3, 4, 5 }, "23a0c210-a2a6-4369-a156-d9e06d860845", "Pode realizar todas as ações/operações em dashboard comercial", "CanDashboardComercialAll", "CANDASHBOARDCOMERCIALALL", "ac-dashboardComercial-page" },
                    { "824ba7d5-e183-4426-9c7e-6ab78b2bddd3", new[] { 1, 2, 3, 4, 5 }, "395a846f-feb9-4b76-8801-e148198d4534", "Pode realizar todas as ações/operações em todos os contratos vinculados a vendedores", "CanVendedorContratoAll", "CANVENDEDORCONTRATOALL", "ac-vendedorContrato-page" },
                    { "824f5f77-96c8-4f11-96b7-7bde39323b27", new[] { 4 }, "cd842aa6-88b7-40c0-800f-657ecb4390a9", "Pode criar um vínculo de contrato a um vendedor", "CanVendedorContratoUpdate", "CANVENDEDORCONTRATOUPDATE", "ac-vendedorContrato-page" },
                    { "865b8a41-dcdb-4db2-b9e8-55f849660562", new[] { 5 }, "2d52fbf8-34b7-4809-8fa8-f5f45d0f028d", "Pode listar os dados de todas as chaves de api de terceiro", "CanChaveApiTerceiroDelete", "CANCHAVEAPITERCEIRODELETE", "ac-chaveApiTerceiro-page" },
                    { "86a9d842-77ce-433d-9349-483bf87ca313", new[] { 5 }, "485d2083-0ce9-4192-82cb-46b2cf0b5dad", "Pode deletar uma comissão de vendedor", "CanVendedorComissaoDelete", "CANVENDEDORCOMISSAODELETE", "ac-vendedorComissao-page" },
                    { "879e5d4e-6d61-4da1-bfbb-d6d61e0fe7cf", new[] { 1, 2, 3, 4, 5 }, "f48549eb-241b-49b1-8fae-f4376a0e6ed7", "Pode realizar todas as ações/operações em todas as comissões de vendedores", "CanVendedorComissaoAll", "CANVENDEDORCOMISSAOALL", "ac-vendedorComissao-page" },
                    { "884c91d3-2441-49c7-a094-5882f4273098", new[] { 2 }, "70862be1-c897-471c-85cf-3879e2c701b2", "Pode listar os dados de um usuários", "CanUserRead", "CANUSERREAD", "ac-user-page" },
                    { "89477a44-b69d-409b-a4ed-9836a444eba8", new[] { 1 }, "fb46db5e-da08-467a-8c6d-5bbbc0df24dd", "Pode listar os dados de todas as roles/permissões", "CanRoleList", "CANROLELIST", "ac-role-page" },
                    { "89719049-b438-4b9a-ba6a-ea0417c2a655", new[] { 1, 2, 3, 4, 5 }, "8564d53c-f596-4889-824b-66919e4f2fc7", "Pode realizar todas as ações/operações em todos os fornecedores", "CanFornecedorAll", "CANFORNECEDORALL", "ac-fornecedor-page" },
                    { "8a6a25ff-511b-4672-9126-dc44e6ec2e85", new[] { 1 }, "0d4563b5-58ae-4a51-8c3c-a64579ec6f57", "Pode listar os dados de todas as chaves de api de terceiro", "CanChaveApiTerceiroList", "CANCHAVEAPITERCEIROLIST", "ac-chaveApiTerceiro-page" },
                    { "8a83b6c2-2571-42b9-8918-fff4552edf23", new[] { 4 }, "8f8be97d-87b6-4271-8577-7bc3d1f444fb", "Pode criar um produto de fornecedor", "CanFornecedorProdutoUpdate", "CANFORNECEDORPRODUTOUPDATE", "ac-fornecedorProduto-page" },
                    { "8d2da32e-e3e2-46d9-a12a-69dcc30bbbe0", new[] { 2 }, "35b30baa-6ad0-486c-bdf5-33bbc1b69202", "Pode listar os dados de um fornecedor", "CanFornecedorRead", "CANFORNECEDORREAD", "ac-fornecedor-page" },
                    { "8d9e59e7-50f0-4cc2-a8d5-246b31966809", new[] { 1 }, "dc195de2-4a57-412d-8883-60a88d779845", "Pode listar todas as rotinas events histories", "CanRotinaEventHistoryList", "CANROTINAEVENTHISTORYLIST", "ac-rotinaEventHistory-page" },
                    { "8de83a31-9ec3-4bbf-b5c2-4a237c63f42c", new[] { 4 }, "98254055-67d5-40b6-bb5a-7e369539d872", "Pode atualizar um serviço", "CanServicoUpdate", "CANSERVICOUPDATE", "ac-servico-page" },
                    { "8fc421f6-44fb-41ca-9a20-97bea2cb2027", new[] { 1, 2, 3, 4, 5 }, "4d5424b4-0d5d-40da-8f4f-5b3ea54f35e7", "Pode realizar todas as ações/operações em todos os vendedores", "CanVendedorAll", "CANVENDEDORALL", "ac-vendedor-page" },
                    { "9026bed6-13dc-465d-a989-bac4908b0151", new[] { 3 }, "5331635e-eb3e-4437-ad36-a1007bbf5c96", "Pode visualizar uma comissão de vendedor", "CanVendedorComissaoCreate", "CANVENDEDORCOMISSAOCREATE", "ac-vendedorComissao-page" },
                    { "9211fbeb-41a6-4c07-bdf9-0a8d6199ccde", new[] { 1 }, "b58f9ed8-fe13-4fdc-9c87-e42a59bed6e0", "Pode listar os dados de todos os contratos vinculados a vendedores", "CanVendedorContratoList", "CANVENDEDORCONTRATOLIST", "ac-vendedorContrato-page" },
                    { "95a2cf5e-4d12-43e0-a2eb-52ed8e7c8388", new[] { 1, 2, 3, 4, 5 }, "576ce5d8-61ff-4761-a224-8b5a75c6b711", "Pode realizar todas as ações/operações relacionadas a entidade rotina event history", "CanRotinaEventHistoryAll", "CANROTINAEVENTHISTORYALL", "ac-rotinaEventHistory-page" },
                    { "95e78aa1-062b-478a-b011-fca063cfb95c", new[] { 1, 2, 3, 4, 5 }, "aabbc520-2dfd-4c23-96a9-9bf45f3552ac", "Pode realizar todas as ações/operações em todos os produtos de clientes", "CanClienteProdutoAll", "CANCLIENTEPRODUTOALL", "ac-clienteProduto-page" },
                    { "96df3754-247b-4984-8ad6-334a94134d6f", new[] { 1, 2, 3, 4, 5 }, "0f4306cd-4395-4b3c-aadd-a5f0e66db832", "Pode listar todas as rotinas events histories", "CanVendedorRelatorioAll", "CANVENDEDORRELATORIOALL", "ac-vendedorRelatorio-page" },
                    { "9ec64f4c-c84c-45f9-ad83-94b4f9dfcbc4", new[] { 5 }, "64ba1ad9-81bd-45e9-9c83-d31095824d72", "Pode deletar um fornecedor", "CanForncedorDelete", "CANFORNCEDORDELETE", "ac-forncedor-page" },
                    { "a0315302-df87-49a9-ae22-0bfb4ea04c87", new[] { 1 }, "f2d862e9-2125-461e-9d47-344bd7a6d133", "Pode realizar todas as ações/operações relacionadas a relatórios de vendedores", "CanVendedorRelatorioComissaoList", "CANVENDEDORRELATORIOCOMISSAOLIST", "ac-vendedorRelatorioComissao-page" },
                    { "a08c5234-4cf9-4296-ad34-730135fe1f20", new[] { 5 }, "c846ace6-9915-4301-82d5-670c5d1500a9", "Pode deletar um produtos", "CanProdutoDelete", "CANPRODUTODELETE", "ac-produto-page" },
                    { "a1b51109-adb6-401d-97b0-07bd844c0b61", new[] { 1 }, "7466cc77-2ebc-47f1-8aaa-718d03d1eda2", "Pode listar os dados de todos os fornecedores", "CanFornecedorList", "CANFORNECEDORLIST", "ac-fornecedor-page" },
                    { "a257e78b-5248-4738-9859-f0132c3c6788", new[] { 5 }, "b095dbb5-7389-4de4-9d9b-2879e30af6fe", "Pode deletar um usuário", "CanUserDelete", "CANUSERDELETE", "ac-user-page" },
                    { "a3b18a5f-443e-44bf-a6ff-75043b0f55b4", new[] { 1 }, "67403820-9c53-490e-a6a5-81a46e5fdb37", "Pode listar os dados de todos os clientes", "CanClienteList", "CANCLIENTELIST", "ac-cliente-page" },
                    { "a62758e2-2a8c-447a-b937-9f7c2b3293fe", new[] { 3 }, "27165720-e568-475e-b4e7-e2dc10dd59f3", "Pode criar um serviço para um cliente", "CanClienteServicoCreate", "CANCLIENTESERVICOCREATE", "ac-clienteServico-page" },
                    { "a76ae720-c60c-48ed-92b2-c993bdb78b92", new[] { 1, 2, 3, 4, 5 }, "a2e937e9-5418-4db6-92e3-075bc6a9b216", "Pode realizar todas as ações/operações relacionadas a entidade de sistema rotina", "CanRotinaAll", "CANROTINAALL", "ac-rotina-page" },
                    { "a8b16d9e-c0ff-4a7c-9ae2-4802205a1f7d", new[] { 2 }, "2324081b-022b-4520-a44c-09b681490b0b", "Pode listar os dados de um produto de fornecedor", "CanFornecedorProdutoRead", "CANFORNECEDORPRODUTOREAD", "ac-fornecedorProduto-page" },
                    { "aa50a4e3-9647-43ba-bbd2-a6d2ce86636c", new[] { 1 }, "bfe5c0c8-f19c-4c41-953a-d51b89e14349", "Pode listar os dados de todos os produtos", "CanProdutoList", "CANPRODUTOLIST", "ac-produto-page" },
                    { "b0f96d85-3647-4651-9f78-b7529b577ec0", new[] { 0 }, "4629cea3-3b65-43b9-9c4e-7cc68fe4e4e4", "Pode realizar todas as ações/operações, bem como ter acesso a todos os dados e funcionalidades", "Master", "MASTER", "all" },
                    { "b20e3d7c-5ee7-4ffd-85ad-9b8a4711ea0c", new[] { 2 }, "e27bdb56-62cb-45ff-8c99-7179798887f4", "Pode listar os dados de um produto de cliente", "CanClienteProdutoRead", "CANCLIENTEPRODUTOREAD", "ac-clienteProduto-page" },
                    { "b38c0667-aff9-40ed-a33c-bd1cca752824", new[] { 3 }, "119d5f52-a10d-41d4-9ff5-1a287094fba6", "Pode criar um cliente", "CanClienteCreate", "CANCLIENTECREATE", "ac-cliente-page" },
                    { "b4354228-da54-4202-98ef-a833364f5945", new[] { 5 }, "0263e7d8-ff1c-43a1-b154-4c6f51fc5be1", "Pode deletar uma role/permissão", "CanRoleDelete", "CANROLEDELETE", "ac-role-page" },
                    { "b46580b0-f1e6-4ba2-8a82-1f715294a624", new[] { 2 }, "a7f8a0bb-8516-49ef-ba3e-fcf18c3a703e", "Pode listar os dado de um grupo", "CanGroupRead", "CANGROUPREAD", "ac-group-page" },
                    { "b6d34855-c6a5-4e5c-8a2c-0ee87b8cf0a9", new[] { 4 }, "a4acb3ce-329b-49de-9137-c627b127b446", "Pode atualizar os dados de uma roles/permissão", "CanRoleUpdate", "CANROLEUPDATE", "ac-role-page" },
                    { "bc460513-284f-4421-bcfb-b260e7071ccb", new[] { 1 }, "d9319c9e-d8c9-46e1-917e-eee1a90a036b", "Pode listar os dados de todos os serviços de fornecedores", "CanFornecedorServicoList", "CANFORNECEDORSERVICOLIST", "ac-fornecedorServico-page" },
                    { "c15d6bca-9bd4-4552-8561-f888baf900c7", new[] { 1, 2, 3, 4, 5 }, "29deca97-c260-4158-b86c-b92111f53643", "Pode realizar todas as ações/operações em todos os serviços", "CanServicoAll", "CANSERVICOALL", "ac-servico-page" },
                    { "c55b45b7-9416-40b2-878b-17b49fcd0b28", new[] { 1 }, "454a02c5-1df0-45a9-87e5-5a585ad1c1da", "Pode listar os dados de todos os serviços de clientes", "CanClienteServicoList", "CANCLIENTESERVICOLIST", "ac-clienteServico-page" },
                    { "c5db78d0-7dca-4e8b-a28f-a9b21313613f", new[] { 3 }, "0d59a83c-6970-49c2-98b7-8beba016d32e", "Pode criar um fornecedor", "CanFornecedorCreate", "CANFORNECEDORCREATE", "ac-fornecedor-page" },
                    { "c7c84d59-67b1-47e3-9aed-d2747a204cce", new[] { 5 }, "aabf378d-53df-450b-a672-b8c37fe511ba", "Pode deletar um produto de fornecedor", "CanFornecedorProdutoDelete", "CANFORNECEDORPRODUTODELETE", "ac-fornecedorProduto-page" },
                    { "cc1badab-56bf-4691-ac1f-e55ccd65fbbb", new[] { 2 }, "52c00964-11b2-4eeb-9df1-784e242da6c1", "Pode listar os dado de um cliente", "CanClienteRead", "CANCLIENTEREAD", "ac-cliente-page" },
                    { "cfb1eb4b-9ff9-4fed-bd04-6fee862e9986", new[] { 3 }, "0a06f2f5-ceb8-454b-97ab-a8d2df0ff04a", "Pode criar um grupo", "CanGroupCreate", "CANGROUPCREATE", "ac-group-page" },
                    { "d08969a5-9b9c-4298-918d-84a9245c2d5c", new[] { 1 }, "19be0345-b903-4e80-93be-176fd25e2f1d", "Pode listar os dados de todos os vendedores", "CanVendedorList", "CANVENDEDORLIST", "ac-vendedor-page" },
                    { "d14fd503-fadd-4d5d-ab18-f8e1e92b4817", new[] { 4 }, "bc02651b-557b-484e-9217-7a093a4c0103", "Pode atualizar os dados de rotinas", "CanRotinaUpdate", "CANROTINAUPDATE", "ac-rotina-page" },
                    { "d2e89c55-ee22-4aed-be3f-8bd8e16b5b56", new[] { 1 }, "b832e2c3-6082-4394-b1c8-64ebaca34bbe", "Pode listar os dados de todas as faturas de contratos de clientes", "CanClienteContratoFaturaList", "CANCLIENTECONTRATOFATURALIST", "ac-clienteContratoFatura-page" },
                    { "d3ad6cf6-2c87-460c-bd86-981187de6116", new[] { 5 }, "896d7840-639c-4308-b1fb-93a913fe7422", "Pode deletar um serviço de um cliente", "CanClienteServicoDelete", "CANCLIENTESERVICODELETE", "ac-clienteServico-page" },
                    { "d51e71d9-7e8e-45a6-9842-9a893fd293a6", new[] { 1, 2, 3, 4, 5 }, "8c7529d1-5db2-489d-aa31-9d6780a27acf", "Pode visualizar todos os indicadores da dashboard comercial", "CanClienteAll", "CANCLIENTEALL", "ac-cliente-page" },
                    { "d56cc7a7-87c2-4daa-b649-6baf1f54c5ed", new[] { 3 }, "d95b12a9-be38-4ed4-9453-d9339f718ff0", "Pode criar um contrato de cliente", "CanClienteContratoCreate", "CANCLIENTECONTRATOCREATE", "ac-clienteContrato-page" },
                    { "d7e1338b-0ec4-40a9-9f43-2038cbb0e104", new[] { 2 }, "cbac4c4f-0de2-431f-a690-255513d9563c", "Pode listar os dados de um serviço", "CanServicoRead", "CANSERVICOREAD", "ac-servico-page" },
                    { "d85eb0e6-3838-41df-8733-dc726131cb04", new[] { 2 }, "1d68b5bf-683a-473b-b628-846a04d49c7a", "Pode listar os dados de um contrato de cliente", "CanClienteContratoRead", "CANCLIENTECONTRATOREAD", "ac-clienteContrato-page" },
                    { "d91b8dc4-c920-4d2b-9dfd-b8ad7020c268", new[] { 2 }, "3c7b20ce-ca03-4495-baa2-3fe6e5f30cac", "Pode listar os dados de um vendedor", "CanVendedorRead", "CANVENDEDORREAD", "ac-vendedor-page" },
                    { "de8b08fa-2386-4535-8413-e25ae4c9417f", new[] { 1 }, "8f15ddfb-d5ec-4107-b3b1-feb64be02b19", "Pode listar os dados de todos os pipelines", "CanPipelineList", "CANPIPELINELIST", "ac-pipeline-page" },
                    { "e151275d-523a-4bd0-9dfc-d419968859ae", new[] { 3 }, "66c23ce5-8234-4880-9322-a360af3dee06", "Pode criar um serviço", "CanServicoCreate", "CANSERVICOCREATE", "ac-servico-page" },
                    { "e3785174-ce5f-4ae0-b45a-40778c605501", new[] { 1, 2, 3, 4, 5 }, "101e9258-bb73-4c4e-94e6-099b88f0c970", "Pode realizar todas as ações/operações em todas as faturas de contratos de clientes", "CanClienteContratoFaturaAll", "CANCLIENTECONTRATOFATURAALL", "ac-clienteContratoFatura-page" },
                    { "e731ce7e-fe85-42d1-8f5e-3053f8c2edb8", new[] { 2 }, "b980171c-9238-41e7-a40e-768e0a192370", "Pode listar os dados de uma fatura de contrato de cliente", "CanClienteContratoFaturaRead", "CANCLIENTECONTRATOFATURAREAD", "ac-clienteContratoFatura-page" },
                    { "eb45344e-eea0-41c6-b1c9-d0591f10ee9d", new[] { 1, 2, 3, 4, 5 }, "33bfe76e-ba76-427a-9af8-9f781f9451fe", "Pode realizar todas as ações/operações em dashboard publica", "CanDashboardPublicaAll", "CANDASHBOARDPUBLICAALL", "ac-dashboardPublica-page" },
                    { "ec45616c-e773-436a-9463-197ca0a6122d", new[] { 3 }, "85e6f662-dfb7-4fbd-b74d-015fb23ecc6b", "Pode criar um serviço para um fornecedor", "CanFornecedorServicoCreate", "CANFORNECEDORSERVICOCREATE", "ac-fornecedorServico-page" },
                    { "eea25f13-ed84-4dd2-a49b-80903b6b6318", new[] { 1 }, "f47bad89-a059-44e8-94c8-4d4109d5e1a0", "Pode listar os dados de todos os produtos de fornecedores", "CanFornecedorProdutoList", "CANFORNECEDORPRODUTOLIST", "ac-fornecedorProduto-page" },
                    { "ef499dd3-07f2-4e7a-9d0e-be357df61d3c", new[] { 4 }, "b7c6a074-9e6e-45f0-a58e-e9ce0ed052d5", "Pode listar os dados de todas as chaves de api de terceiro", "CanChaveApiTerceiroUpdate", "CANCHAVEAPITERCEIROUPDATE", "ac-chaveApiTerceiro-page" },
                    { "f25608ef-5dcf-4a95-ae5b-42643bd41725", new[] { 1 }, "870fa388-3244-4954-b851-50223afe1ce0", "Pode listar o título dos negócios", "CanTitleBussinesList", "CANTITLEBUSSINESLIST", "ac-titleBussines-page" },
                    { "f54526ea-5c75-4c61-8f1f-0ce6c3c5c2f9", new[] { 3 }, "2c7c74ac-2424-427f-802a-84835f1dc113", "Pode visualizar um vendedor", "CanVendedorCreate", "CANVENDEDORCREATE", "ac-vendedor-page" },
                    { "fa95f57b-98f0-4fcf-913e-1a1b65557f2c", new[] { 2 }, "dbcf203e-872a-4b66-9636-8e9d819392e9", "Pode listar os dados de uma rotina event history", "CanRotinaEventHistoryRead", "CANROTINAEVENTHISTORYREAD", "ac-rotinaEventHistory-page" },
                    { "faad94bf-42b4-4880-9313-f08cc1fd59fd", new[] { 4 }, "709e5bd9-c506-4d76-a365-2ea7fd745898", "Pode criar uma fatura de contrato de cliente", "CanClienteContratoFaturaUpdate", "CANCLIENTECONTRATOFATURAUPDATE", "ac-clienteContratoFatura-page" },
                    { "fc8d5177-1e59-4259-bf27-4d1402fc04e1", new[] { 1, 2, 3, 4, 5 }, "65270040-bbed-47db-83b3-ad59af87760d", "Pode listar os dados de todas as chaves de api de terceiro", "CanChaveApiTerceiroAll", "CANCHAVEAPITERCEIROALL", "ac-chaveApiTerceiro-page" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "UserId", "AccessFailedCount", "Avatar", "Bio", "ConcurrencyStamp", "DataAniversario", "Email", "EmailConfirmed", "FullName", "Funcao", "Genero", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Setor", "Status", "TenantId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, null, null, "ca431822-360a-4ee6-b978-66564d429fc7", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, false, null, 0, 0, false, null, null, "ALAN.REZENDEEE@HOTMAIL.COM", "AQAAAAEAACcQAAAAEFGbgHKOKiDDs5fvXN8kHviorntHToMKurnVJNmsFQNInxhQOyZTwJ2w0SpbyCdZbA==", null, false, "c9514850-61dd-4cc1-b909-88b79b035643", 0, 0, null, false, "alan.rezendeeee@hotmail.com" });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "Id", "ApiKey", "CreatedAt", "CreatedBy", "EmailPrincipal", "EnderecoBairro", "EnderecoCEP", "EnderecoCidade", "EnderecoEstado", "EnderecoLogradouro", "EnderecoLogradouroNumero", "IsDeleted", "Nome", "NomeExibicao", "OficioLeituraAssinaturaCargo", "OficioLeituraAssinaturaMatricula", "OficioLeituraAssinaturaNome", "OficioLeituraVocativo1", "OficioLeituraVocativo2", "OficioLeituraVocativo3", "TelefoneDDD", "TelefoneNumero", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("206c645a-2966-4ad9-19a3-dced7c201bc4"), new Guid("06b5fb02-57cb-126b-3ab2-a05f805f1e97"), new DateTimeOffset(new DateTime(2023, 1, 21, 16, 40, 56, 517, DateTimeKind.Unspecified).AddTicks(5954), new TimeSpan(0, 0, 0, 0, 0)), new Guid("8e445865-a24d-4543-a6c6-9443d048cdb9"), null, null, null, null, null, null, null, false, "Tenância Presídio Regional de Criciúma", "PRESÍDIO REGIONAL CRICIÚMA", null, null, null, null, null, null, null, null, new DateTimeOffset(new DateTime(2023, 1, 21, 16, 40, 56, 517, DateTimeKind.Unspecified).AddTicks(5959), new TimeSpan(0, 0, 0, 0, 0)), new Guid("8e445865-a24d-4543-a6c6-9443d048cdb9") });

            migrationBuilder.InsertData(
                table: "AspNetGroups",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "TenantId", "UniqueKey", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"), new DateTimeOffset(new DateTime(2023, 1, 21, 16, 40, 56, 522, DateTimeKind.Unspecified).AddTicks(3613), new TimeSpan(0, 0, 0, 0, 0)), new Guid("8e445865-a24d-4543-a6c6-9443d048cdb9"), false, "Master", new Guid("206c645a-2966-4ad9-19a3-dced7c201bc4"), "ors0eAr4DPkvrwhy5gVnQAqRDnJUO43j9HzbkPyZ/7Q=", new DateTimeOffset(new DateTime(2023, 1, 21, 16, 40, 56, 522, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 0, 0, 0, 0)), new Guid("8e445865-a24d-4543-a6c6-9443d048cdb9") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b0f96d85-3647-4651-9f78-b7529b577ec0", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetRoleGroups",
                columns: new[] { "GroupId", "RoleId" },
                values: new object[] { new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"), "b0f96d85-3647-4651-9f78-b7529b577ec0" });

            migrationBuilder.InsertData(
                table: "AspNetUserGroups",
                columns: new[] { "GroupId", "UserId" },
                values: new object[] { new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"), "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationNotifications_TenantId",
                table: "ApplicationNotifications",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationNotifications_UserId",
                table: "ApplicationNotifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetGroups_TenantId",
                table: "AspNetGroups",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleGroups_GroupId",
                table: "AspNetRoleGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserGroups_GroupId",
                table: "AspNetUserGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TenantId",
                table: "AspNetUsers",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_ApiKey",
                table: "Tenants",
                column: "ApiKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VerticalNavItems_VerticalNavItemId",
                table: "VerticalNavItems",
                column: "VerticalNavItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationNotifications");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetRoleGroups");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserGroups");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "VerticalNavItems");

            migrationBuilder.DropTable(
                name: "AspNetGroups");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Tenants");
        }
    }
}
