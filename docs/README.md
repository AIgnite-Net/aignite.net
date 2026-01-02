---
description: AIgnite Landing Page
---

# Introduction

AIgnite.Net is a template project for LLM-Centric, Agentic AI projects in .NET. Read on to understand why this was started and how you can contribute.

# Initial Idea

With the onslaught of AI, we need to start thinking about how we can use AI to solve problems. And by problems, I mean real world production problems - such as scaling, security, and more.

With the coding assistants evolving and improving very fast, the speed at which products are developed (and even deployed in some cases) is amazing!

While the development time is shrinking on one side, debugging is also becoming easier with AI-based chats integrated with modern IDEs. So far so good.

What happens when the products are deployed and used in the field? How will field-observability and complex bugs from the field be fixed?

While there are definitely no right answer for these questions, and many of these are yet to be experienced, one aspect is certain: having a predictable backend architecture with a large number of common aspects built into it will take the speed of development and deployment to even greater heights.

This thought drove the initial idea for development of a pluggable system that acts as a starting point for any AI projects.

We call this AIgnite - a moniker with "AI" and "Ignite" fused together - for igniting your AI projects! We have the .Net in the name as this project aims to be the starting point for .NET AI projects.

# Phases of product creation

Generally, every product gets created in two phases. The first phase (product-market-fit) is largely to spot problems and finalise a "product idea" to solve those problems. The second phase is to actually create the product to run it in scale, both for for real value to customers and a financially viable business.

Phase-1 and Phase-2 repeatedly iterates to get the perfect balance for a viable business and the best customer value.

# Where does AIgnite.Net fit?

AIgnite.Net is to fit both the above phases of an AI-based .Net product. What we want to do is to decouple the backend and the front-end in such a manner that phase-1 can work with a minimal backend, and concentrate largely on the best front-end for demonstrations and a simple backend business logic. Phase-2 will be largely to take the backend, and build it for scale.

# Ethos of AIgnite.Net

Well, LLMs are real. It is time that we embrace them - unlike in the intial days - even until 2024 or so, they were just toys. 2025 is the year to embrace them in products for real value. Any year before this was, well, a joke :-) And come 2026, build Agents of AI! That's how it is going to be.

While the likes of ChatGpt, Claude, etc. are great for generating small products with not-so-complex scale-needs, AIgnite.Net is to complement them with:

- Good architected backend and front-end
- Robust API-first design, MCP-ready for future-proofing
- Cloud-agnostic backend, but also edge-ready

# What is AIgnite.Net?

AIgnite.Net is a .Net project that is to be used as a starting point for AI-based products. It is a simple Chatbot - and the backend is simple use of APIs to OpenAI / Ollama models (which, of course, can be replaced with any LLM of your choice). The idea is not to develop any complex use-cases, it is only to build a good backend architecture with plugable use-case models that you can develop and plugin.

# Tech stack

## Drivers

The tech stack is opinionated. The drivers for such a tech stack are:

- Cross-platform (Windows, Linux, Mac, Android, iOS). We will also support WASM for browser-based applications.
- Free for development and commercial use, atleast for indie developers and small businesses
- Robust decoupling of backend and frontend
- .NET-based - well, that's why we have this project in the first place :-)
- Open source with permissive license - so it can simply be adapted for your needs

## Stack

- .NET (we will strive to be at the latest versions)
- Uno platform for cross-platform development
- C# Markup + MVUX as code and architectural patterns
- OpenAI / Ollama API at the backend

# How can you contribute?

AIgnite.Net's github page is here:

[GitHub - AIgnite-Net/aignite.net: Starting point for .NET based LLM-centric, Agentic, and the next-big-thing projects...](https://github.com/AIgnite-Net/aignite.net)

To contribute, checkout the [CONTRIBUTING.md](https://github.com/AIgnite-Net/aignite.net/blob/main/CONTRIBUTING.md) file.
