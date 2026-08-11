module Config

open System.IO

// --- Site metadata (edit these for your site) ---
// Only change the values in quotes - the rest is just labels.
let siteTitle = "Chiruno9 的小站"
let siteDescription = "记录我的编程学习日志 · 模组开发"
let siteBaseUrl = "https://tensai-chiruno.github.io"  // No trailing slash. Include repo name if using project pages.
let siteLanguage = "zh"
let siteAuthor = "Chiruno9"  // Optional, used in RSS feed and meta tags
let siteImage = "assets/avatar.jpg"  // Optional, preview image for social shares (og:image), relative to site root. "" disables

// --- Interface text (translate these if your blog is not in English) ---
let blogEntriesHeading = "文章列表"  // Section heading above the post list on the front page
let publishedOnText = "发布于"  // Shown before the date at the end of each post
let untitledPageTitle = "无标题"  // Fallback title for pages without a # heading
let notFoundTitle = "页面未找到"  // Browser tab title of the 404 page
let notFoundMessage = "该页面不存在或已被移动。"  // 404 page text
let notFoundBackText = "返回首页"  // 404 page link text

// --- Folder layout (you normally don't need to touch these) ---
let sourceDir = __SOURCE_DIRECTORY__

let markdownDir = Path.Combine(sourceDir, "markdown-blog")
let htmlDir = Path.Combine(sourceDir, "html")
let outputDir = Path.Combine(sourceDir, "skunk-html-output")

let cssDir = Path.Combine(sourceDir, "css")
let outputCssDir = Path.Combine(outputDir, "css")

let fontsDir = Path.Combine(sourceDir, "fonts")
let outputFontsDir = Path.Combine(outputDir, "fonts")

let imagesDir = Path.Combine(markdownDir, "images")
let outputImagesDir = Path.Combine(outputDir, "images")

let assetsDir = Path.Combine(sourceDir, "assets")
let outputAssetsDir = Path.Combine(outputDir, "assets")

let scriptsDir = Path.Combine(sourceDir, "scripts")
let outputScriptsDir = Path.Combine(outputDir, "scripts")

let frontPageMarkdownFileName = "index.md"
