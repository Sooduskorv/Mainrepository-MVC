﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace Sooduskorv.IDP
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Address(),
                new IdentityResource("roles",
                    "Your role(s)",
                    new List<string>() { "role" }),
                new IdentityResource(
                    "subscription",
                    "Your subscription at Sooduskorv",
                    new List<string>() { "subscription" }),
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            {
                new ApiResource("productsapi","Catalog.API", new List<string>() {"role"} )
                {
                    ApiSecrets = { new Secret("apisecret".Sha256()) },
                    Scopes = { "productsapi" }
                },
                new ApiResource(
                    "orderapi","Order.API", new List<string>() {"role"} )
                {
                    ApiSecrets = { new Secret("apisecret".Sha256()) },
                    Scopes = { "orderapi" }
                },
                new ApiResource(
                    "basketapi","Basket.API", new List<string>() {"role"} )
                {
                    ApiSecrets = { new Secret("apisecret".Sha256()) },
                    Scopes = { "basketapi" }
                }
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("productsapi","Catalog.API", new List<string>() {"role"} ),

                new ApiScope("orderapi","Order.API", new List<string>() {"role"} ),

                new ApiScope("basketapi","Basket.API", new List<string>() {"role"} ),
            };


        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientName = "Sooduskorv",
                    AccessTokenType = AccessTokenType.Reference,
                    UpdateAccessTokenClaimsOnRefresh = true,
                    RequirePkce = true,
                    AllowedGrantTypes = GrantTypes.Code,
                    AllowOfflineAccess = true,
                    ClientId = "sooduskorv-mvc",
                    RequireConsent = false,
                    RedirectUris = new List<string>()
                    {
                        "https://localhost:44389/signin-oidc"
                    },
                    PostLogoutRedirectUris = new List<string>()
                    {
                        "https://localhost:44389/signout-callback-oidc"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Address,
                        "roles",
                        "productsapi",
                        "orderapi",
                        "basketapi",
                    },
                    ClientSecrets = {new Secret("secret".Sha256())}
                },
                new Client
                {
                    ClientName = "name",
                    ClientId = "sooduskorv-name",
                    ClientSecrets = {new Secret("a378wefyasugvcbaduio".Sha256())},
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "productsapi" }
                }
            };
    }
}